using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectResponsibleDtos;
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
    [Authorize]
    public class ProjectResponsibleController : BaseController
    {
        IProjectResponsibleService _projectResponsibleManager;
        public ProjectResponsibleController(UserManager<AppUser> userManager, IMapper mapper, IProjectResponsibleService projectResponsibleManager) : base(userManager, mapper)
        {
            _projectResponsibleManager = projectResponsibleManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddProjectResponsible()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Add(ProjectResponsibleAddDto p)
        {
            bool bIsExist = await _projectResponsibleManager.CheckUserExist(p.AppUserId,p.ProjectId);
            if (!bIsExist)
            {
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _projectResponsibleManager.Add(p);
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
