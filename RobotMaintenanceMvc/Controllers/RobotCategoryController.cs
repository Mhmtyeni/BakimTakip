using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotCategoryDtos;
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
    public class RobotCategoryController : BaseController
    {
        private readonly IRobotCategoryService _robotCategoryManager;
        public RobotCategoryController(UserManager<AppUser> userManager, IMapper mapper, IRobotCategoryService robotCategoryManager) : base(userManager, mapper)
        {
            _robotCategoryManager = robotCategoryManager;
        }
        [HttpPost]
        public async Task<JsonResult> Add(RobotCategoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _robotCategoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _robotCategoryManager.GetAll();
            return Json(result.Data);
        }
        public async Task<JsonResult> GetById(int Id)
        {
            var result = await _robotCategoryManager.GetById(Id);
            return Json(result.Data);
        }

        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> RobotCategory()
        {
            var result = await _robotCategoryManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(RobotCategoryUpdateDto p)
        {
            var result2 = await _robotCategoryManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.RobotCategory.CreatedByName;
            p.CreatedDate = result2.Data.RobotCategory.CreatedDate;
            var result = await _robotCategoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(RobotCategoryUpdateDto p)
        {
            var result2 = await _robotCategoryManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.RobotCategory.CreatedByName;
            p.CreatedDate = result2.Data.RobotCategory.CreatedDate;
            p.IsActive = false;
            p.IsDeleted = true;
            var result = await _robotCategoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }

    }
}
