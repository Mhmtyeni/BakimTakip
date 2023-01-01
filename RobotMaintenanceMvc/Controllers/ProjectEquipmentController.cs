using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectEquipmentDtos;
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
    public class ProjectEquipmentController : BaseController
    {
        private readonly IProjectEquipmentService _projectEquipmentManager;
        private readonly IEquipmentService _equipmentManager;
        public ProjectEquipmentController(UserManager<AppUser> userManager, IMapper mapper, IProjectEquipmentService projectEquipmentManager, IEquipmentService equipmentManager) : base(userManager, mapper)
        {
            _projectEquipmentManager = projectEquipmentManager;
            _equipmentManager = equipmentManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddProjectEquipment()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Add(ProjectEquipmentAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _projectEquipmentManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<JsonResult> GetByProjectId(int projectId)
        {
            var i = 0;
            var result = await _projectEquipmentManager.GetByProjectId(projectId);
            string[] deneme = new string[result.Data.ProjectEquipment.Count];
            foreach (var item in result.Data.ProjectEquipment)
            {
                var result2 = await _equipmentManager.GetById(item.EquipmentId);
                deneme[i] = result2.Data.Equipment.Name + "?" + result2.Data.Equipment.Id;
                i++;
            }
            return Json(deneme);
        }
        public async Task<JsonResult> GetAllProjectEquipmentId(int projectId)
        {
            var i = 0;
            var result = await _projectEquipmentManager.GetAllEquipment(projectId);
            string[] deneme = new string[result.Data.ProjectEquipment.Count];
            foreach (var item in result.Data.ProjectEquipment)
            {
                var result2 = await _equipmentManager.GetById(item.EquipmentId);
                deneme[i] = result2.Data.Equipment.Name + "?" + result2.Data.Equipment.Id + "|" + item.Id;
                i++;
            }
            return Json(deneme);
        }
        public async Task<JsonResult> GetByProjectIdEquipmentId(int Id)
        {
            var i = 0;
            var result = await _projectEquipmentManager.GetByProjectId(Id);
            string[] deneme = new string[result.Data.ProjectEquipment.Count];
            foreach (var item in result.Data.ProjectEquipment)
            {
                var result2 = await _equipmentManager.GetById(item.EquipmentId);
                deneme[i] = result2.Data.Equipment.Name + "?" + result2.Data.Equipment.Id + "|" + item.Id;
                i++;
            }
            return Json(deneme);
        }
        public async Task<JsonResult> GetByProjectEquipmentId(string sEquipmentId)
        {
            var start = sEquipmentId.IndexOf("?");
            var equipmentId = Convert.ToInt32(sEquipmentId.Substring(0, start));
            var end = sEquipmentId.Length - equipmentId.ToString().Length;
            var projectId = Convert.ToInt32(sEquipmentId.Substring(start + 1, end - 1));
            var projectEquipmentId = 0;
            var result = await _projectEquipmentManager.GetByEquipmentId(equipmentId);
            foreach (var item in result.Data.ProjectEquipment)
            {
                if (!item.CheckMaintenance)
                {
                    var result2 = await _equipmentManager.GetById(item.EquipmentId);
                    if (item.ProjectId == projectId && item.EquipmentId == equipmentId)
                        projectEquipmentId = item.Id;
                }

            }
            return Json(projectEquipmentId);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _projectEquipmentManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }



    }
}
