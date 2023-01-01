using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    public class EquipmentController : BaseController
    {
        private readonly IEquipmentService _equipmentManager;
        private readonly IProjectService _projectManager;
        private readonly IProjectEquipmentService _projectEquipmentManager;
        public EquipmentController(UserManager<AppUser> userManager, IMapper mapper, IEquipmentService equipmentManager, IProjectService projectManager, IProjectEquipmentService projectEquipmentManager) : base(userManager, mapper)
        {
            _equipmentManager = equipmentManager;
            _projectManager = projectManager;
            _projectEquipmentManager = projectEquipmentManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddEquipment()
        {
            var result = await _equipmentManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(EquipmentAddDto p)
        {
            bool bIsExist = await _equipmentManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.Name = p.Name.ToLower();
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _equipmentManager.Add(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _equipmentManager.GetAll();
            return Json(result.Data);
        }
        public async Task<JsonResult> GetByEquimentCategoryId(int equimentCategoryId)
        {
            var result = await _equipmentManager.GetByEquimentCategoryId(equimentCategoryId);
            return Json(result.Data);
        }
        public async Task<JsonResult> GetById(int equipmentId)
        {
            var result = await _equipmentManager.GetById(equipmentId);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(EquipmentUpdateDto p)
        {
            bool bIsExist = false;
            p.Name = p.Name.ToLower();
            var resultId = await _equipmentManager.GetById(p.Id);
            if (resultId.Data.Equipment.Name != p.Name)
                bIsExist = await _equipmentManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.ModifiedByName = LoggedInUser.UserName;
                p.ModifiedDate = DateTime.Now;
                var result = await _equipmentManager.Update(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(EquipmentUpdateDto p)
        {
            var result = await _equipmentManager.GetById(p.Id);
            p.Name = result.Data.Equipment.Name;
            p.Period = result.Data.Equipment.Period;
            p.MaintenanceComment = result.Data.Equipment.MaintenanceComment;
            p.MaintenanceName = result.Data.Equipment.MaintenanceName;
            p.EquipmentCategoryId = result.Data.Equipment.EquipmentCategoryId;
            p.Note = result.Data.Equipment.Note;
            p.CreatedDate = result.Data.Equipment.CreatedDate;
            p.CreatedByName = result.Data.Equipment.CreatedByName;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = false;
            p.IsDeleted = true;
            var result2 = await _equipmentManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Copy(EquipmentUpdateDto p)
        {
            var result = await _equipmentManager.GetById(Convert.ToInt32(p.Note));
            var count = await _equipmentManager.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
            {
                EquipmentAddDto addEquipment = new EquipmentAddDto
                {
                    Name = result.Data.Equipment.Name + count.Data.Equipments.Count.ToString(),
                    Period = result.Data.Equipment.Period,
                    MaintenanceName = result.Data.Equipment.MaintenanceName,
                    MaintenanceComment = result.Data.Equipment.MaintenanceComment,
                    EquipmentCategoryId = result.Data.Equipment.EquipmentCategoryId,
                    CreatedDate = DateTime.Now,
                    CreatedByName = LoggedInUser.UserName,
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = LoggedInUser.UserName,
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Kopyalanarak oluşturulmuştur."

                };
                var resultComplete = await _equipmentManager.Add(addEquipment);
                if (resultComplete.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            return Json(false);
        }
        public async Task<IActionResult> AllEquipment()
        {
            var result = await _equipmentManager.GetAll();
            return View(result.Data);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _equipmentManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Select(int id)
        {
            var result = await _projectEquipmentManager.GetByProjectEquipmentId(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        public async Task<IActionResult> AddProjectEquipment(int id)
        {
            var result = await _projectManager.GetAll();
            foreach (var item in result.Data.Projects)
            {
                item.Note = id.ToString();
            }
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        public async Task<IActionResult> Search(string searchKey)
        {
            if (searchKey != "" && searchKey != " " && searchKey != null)
            {
                var result = await _equipmentManager.SearchByKeyword(searchKey);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
            }
            return View();
        }
    }
}
