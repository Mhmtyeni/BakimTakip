using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    public class AppUserController : BaseController
    {
        private readonly IAppUserService _appUserManager;
        public AppUserController(UserManager<AppUser> userManager, IMapper mapper, IAppUserService appUserManager) : base(userManager, mapper)
        {
            _appUserManager = appUserManager;
        }

        public async Task<JsonResult> GetAll()
        {
            var result = await _appUserManager.GetAll();
            return Json(result.Data);
        }
    }
}
