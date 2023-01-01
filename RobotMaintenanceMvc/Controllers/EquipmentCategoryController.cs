using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentCategoryDtos;
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
    public class EquipmentCategoryController : BaseController
    {
        private readonly IEquipmentCategoryService _equipmentCategoryManager;
        public EquipmentCategoryController(UserManager<AppUser> userManager, IMapper mapper, IEquipmentCategoryService equipmentCategoryManager) : base(userManager, mapper)
        {
            _equipmentCategoryManager = equipmentCategoryManager;
        }

        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> EquipmentCategory()
        {
            var result = await _equipmentCategoryManager.GetAll();
            return View(result.Data);            
        }
        [HttpPost]
        public async Task<JsonResult> Add(EquipmentCategoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _equipmentCategoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _equipmentCategoryManager.GetAll();
            return Json(result.Data);
        }
        public async Task<JsonResult> GetBySubId(int subId)
        {
            var result = await _equipmentCategoryManager.GetBySubId(subId);
            return Json(result.Data);
        }
        public async Task<JsonResult> GetById(int Id)
        {
            var result = await _equipmentCategoryManager.GetById(Id);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(EquipmentCategoryUpdateDto p)
        {
            var result2 = await _equipmentCategoryManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.EquipmentCategory.CreatedByName;
            p.CreatedDate = result2.Data.EquipmentCategory.CreatedDate;
            var result = await _equipmentCategoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(EquipmentCategoryUpdateDto p)
        {
            var result2 = await _equipmentCategoryManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.EquipmentCategory.CreatedByName;
            p.CreatedDate = result2.Data.EquipmentCategory.CreatedDate;
            p.IsActive = false;
            p.IsDeleted = true;
            var result = await _equipmentCategoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
