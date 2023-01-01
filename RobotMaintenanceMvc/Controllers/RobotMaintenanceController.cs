using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotMaintenanceDtos;
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
    public class RobotMaintenanceController : BaseController
    {
        private readonly IRobotMaintenanceService _robotMaintenanceManager;
        private readonly IMaintenanceService _maintenanceManager;
        public RobotMaintenanceController(UserManager<AppUser> userManager, IMapper mapper, IRobotMaintenanceService robotMaintenanceManager, IMaintenanceService maintenanceManager) : base(userManager, mapper)
        {
            _robotMaintenanceManager = robotMaintenanceManager;
            _maintenanceManager = maintenanceManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddRobotMaintenance()
        {
            var result = await _robotMaintenanceManager.GetAll();
            return View(result.Data);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _robotMaintenanceManager.GetAll();
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(RobotMaintenanceAddDto p)
        {
            bool bIsExist = await _robotMaintenanceManager.CheckRobotMaintenanceExist(p.MaintenanceId,p.RobotId);
            if (!bIsExist)
            {
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _robotMaintenanceManager.Add(p);
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
        public async Task<JsonResult> Edit(RobotMaintenanceUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _robotMaintenanceManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<JsonResult> GetByRobotId(int robotId)
        {
            var i = 0;
            var result = await _robotMaintenanceManager.GetRobotId(robotId);
            string[] deneme = new string[result.Data.RobotMaintenances.Count];
            foreach (var item in result.Data.RobotMaintenances)
            {
                var result2 = await _maintenanceManager.GetById(item.MaintenanceId);
                deneme[i] = result2.Data.Maintenance.Name + "?" + result2.Data.Maintenance.Id;
                i++;
            }

            return Json(deneme);
        }
        public async Task<JsonResult> GetAllMaintenance(string sRobotId)
        {
            var start = sRobotId.IndexOf("?");
            var robotId = Convert.ToInt32(sRobotId.Substring(0, start));
            var end = sRobotId.Length - robotId.ToString().Length;
            var maintenanceId = Convert.ToInt32(sRobotId.Substring(start + 1, end - 1));
            var robotMaintenanceId = 0;
            var result = await _robotMaintenanceManager.GetAllMaintenance(robotId);
            foreach (var item in result.Data.RobotMaintenances)
            {
                if (item.MaintenanceId == maintenanceId && item.RobotId == robotId)
                    robotMaintenanceId = item.Id;
            }
            return Json(robotMaintenanceId);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int maintenanceId)
        {
            var result = await _robotMaintenanceManager.DeleteByMaintenanceId(maintenanceId);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
