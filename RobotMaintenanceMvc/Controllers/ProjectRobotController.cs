using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectRobotDtos;
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
    public class ProjectRobotController : BaseController
    {
        private readonly IProjectRobotService _projectRobotManager;
        private readonly IRobotService _robotManager;
        public ProjectRobotController(UserManager<AppUser> userManager, IMapper mapper, IProjectRobotService projectRobotManager, IRobotService robotManager) : base(userManager, mapper)
        {
            _projectRobotManager = projectRobotManager;
            _robotManager = robotManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddProjectRobot()
        {
            return View();
        }
        public async Task<JsonResult> GetByProjectId(int projectId)
        {
            var i = 0;
            var result = await _projectRobotManager.GetByProjectId(projectId);
            string[] deneme = new string[result.Data.ProjectRobots.Count];
            foreach (var item in result.Data.ProjectRobots)
            {
                var result2 = await _robotManager.GetById(item.RobotId);
                deneme[i] = result2.Data.Robot.Name + "?" + result2.Data.Robot.Id;
                i++;
            }
            return Json(deneme);
        }
        public async Task<JsonResult> GetByProjectIdRobotId(int Id)
        {
            var i = 0;
            var result = await _projectRobotManager.GetByProjectId(Id);
            string[] deneme = new string[result.Data.ProjectRobots.Count];
            foreach (var item in result.Data.ProjectRobots)
            {
                var result2 = await _robotManager.GetById(item.RobotId);
                deneme[i] = result2.Data.Robot.Name + "?" + item.Id;
                i++;
            }
            return Json(deneme);
        }
        public async Task<JsonResult> GetByProjectRobotId(string sRobotId)
        {
            var start = sRobotId.IndexOf("?");
            var robotId = Convert.ToInt32(sRobotId.Substring(0, start));
            var end = sRobotId.Length - robotId.ToString().Length;
            var projectId = Convert.ToInt32(sRobotId.Substring(start + 1, end - 1));
            var projectRobotId = 0;
            var result = await _projectRobotManager.GetByRobotId(robotId);
            foreach (var item in result.Data.ProjectRobots)
            {
                var result2 = await _robotManager.GetById(item.RobotId);
                if (item.ProjectId == projectId && item.RobotId == robotId)
                    projectRobotId = item.Id;

            }
            return Json(projectRobotId);
        }

        [HttpPost]
        public async Task<JsonResult> Add(ProjectRobotAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _projectRobotManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _projectRobotManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
