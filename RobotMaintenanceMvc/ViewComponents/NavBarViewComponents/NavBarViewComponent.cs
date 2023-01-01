using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotMaintenanceMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.NavBarViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public NavBarViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            NavBarViewModel model = new NavBarViewModel();
            model.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return View("_navBar", model);
        }
    }
}
