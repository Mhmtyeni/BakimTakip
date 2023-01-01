using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    public class RobotController : BaseController
    {
        private readonly IRobotService _robotManager;
        private readonly IProjectService _projectManager;
        public RobotController(UserManager<AppUser> userManager, IMapper mapper, IRobotService robotManager, IProjectService projectManager) : base(userManager, mapper)
        {
            _robotManager = robotManager;
            _projectManager = projectManager;
        }

        public IActionResult AddRobot()
        {
            return View();
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _robotManager.GetAll();
            return Json(result.Data);
        }
        public async Task<JsonResult> GetByRobotCategoryId(int robotCategoryId)
        {
            var result = await _robotManager.GetByRobotCategoryId(robotCategoryId);
            return Json(result.Data);
        }
        public async Task<JsonResult> GetById(int robotId)
        {
            var result = await _robotManager.GetById(robotId);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(RobotAddDto p)
        {
            bool bIsExist = await _robotManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.Name = p.Name.ToLower();
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _robotManager.Add(p);
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
        public async Task<JsonResult> Edit(RobotUpdateDto p)
        {
            bool bIsExist = false;
            p.Name = p.Name.ToLower();
            var resultId = await _robotManager.GetById(p.Id);
            if (resultId.Data.Robot.Name != p.Name)
                bIsExist = await _robotManager.CheckNameExist(p.Name);
            if (!bIsExist)
            {
                p.ModifiedByName = LoggedInUser.UserName;
                p.ModifiedDate = DateTime.Now;
                var result = await _robotManager.Update(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);
        }
        public async Task<IActionResult> AllRobot()
        {
            var result = await _robotManager.GetAll();
            return View(result.Data);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _robotManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        public async Task<IActionResult> AddProjectRobot(int id)
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
                var result = await _robotManager.SearchByKeyword(searchKey);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
            }
            return View();
        }
    }
}
