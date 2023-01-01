using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDepartmentDtos;
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
    public class FactoryDepartmentController : BaseController
    {
        private readonly IFactoryDepartmentService _factoryDepartmentManager;
        public FactoryDepartmentController(UserManager<AppUser> userManager, IMapper mapper, IFactoryDepartmentService factoryDepartmentManager) : base(userManager, mapper)
        {
            _factoryDepartmentManager = factoryDepartmentManager;
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _factoryDepartmentManager.GetAll();
            return Json(result.Data);
        }
        public async Task<IActionResult> AddDepartment()
        {
            var result = await _factoryDepartmentManager.GetAll();
            return View(result.Data);
        }
        public async Task<JsonResult> GetByFactoryId(int factoryId)
        {
            var result = await _factoryDepartmentManager.GetByFactoryId(factoryId);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(FactoryDepartmentAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _factoryDepartmentManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(FactoryDepartmentUpdateDto p)
        {
            var result2 = await _factoryDepartmentManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.FactoryDepartment.CreatedByName;
            p.CreatedDate = result2.Data.FactoryDepartment.CreatedDate;
            var result = await _factoryDepartmentManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
