using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.MaintenanceDtos;
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
    public class MaintenanceController : BaseController
    {
        private readonly IMaintenanceService _maintenanceManager;
        public MaintenanceController(UserManager<AppUser> userManager, IMapper mapper, IMaintenanceService maintenanceManager) : base(userManager, mapper)
        {
            _maintenanceManager = maintenanceManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddMaintenance()
        {
            var result = await _maintenanceManager.GetAll();
            return View(result.Data);
        }        
        public async Task<JsonResult> GetAll()
        {
            var result = await _maintenanceManager.GetAll();
            return Json(result.Data);
        }       
        public async Task<JsonResult> GetById(int maintenanceId)
        {
            var result = await _maintenanceManager.GetById(maintenanceId);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(MaintenanceAddDto p)
        {
            bool bIsExist = await _maintenanceManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.Name = p.Name.ToLower();
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _maintenanceManager.Add(p);
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
        public async Task<JsonResult> Edit(MaintenanceUpdateDto p)
        {
            bool bIsExist = false;
            p.Name = p.Name.ToLower();
            var resultId = await _maintenanceManager.GetById(p.Id);
            if (resultId.Data.Maintenance.Name != p.Name)
                bIsExist = await _maintenanceManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.ModifiedByName = LoggedInUser.UserName;
                p.ModifiedDate = DateTime.Now;
                var result = await _maintenanceManager.Update(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);
        }       
      
    }
}
