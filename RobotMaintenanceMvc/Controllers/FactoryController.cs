using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDtos;
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
    public class FactoryController : BaseController
    {
        private readonly IFactoryService _factoryManager;
        public FactoryController(UserManager<AppUser> userManager, IMapper mapper, IFactoryService factoryManager) : base(userManager, mapper)
        {
            _factoryManager = factoryManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddFactory()
        {
            var result = await _factoryManager.GetAll();
            return View(result.Data);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _factoryManager.GetAll();
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(FactoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _factoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(FactoryUpdateDto p)
        {
            var result2 = await _factoryManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            p.CreatedByName = result2.Data.Factory.CreatedByName;
            p.CreatedDate = result2.Data.Factory.CreatedDate;
            var result = await _factoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
