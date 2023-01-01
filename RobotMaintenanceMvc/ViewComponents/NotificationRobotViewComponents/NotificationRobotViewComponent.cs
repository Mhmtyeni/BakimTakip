using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.NotificationRobotUserViewComponents
{
    public class NotificationRobotUserViewComponent : ViewComponent
    {

        private readonly IRobotToBeMaintainedUserService _robotToBeMaintainedUserManager;

        public NotificationRobotUserViewComponent(IRobotToBeMaintainedUserService robotToBeMaintainedUserManager)
        {
            _robotToBeMaintainedUserManager = robotToBeMaintainedUserManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _robotToBeMaintainedUserManager.GetAll();
            return View("_notificationRobotUser", result.Data);
        }
    }
}
