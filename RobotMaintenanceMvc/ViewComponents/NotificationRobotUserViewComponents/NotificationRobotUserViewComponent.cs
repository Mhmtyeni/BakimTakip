using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.NotificationRobotViewComponents
{
    public class NotificationRobotViewComponent : ViewComponent
    {

        private readonly IRobotToBeMaintainedService _robotToBeMaintainedManager;

        public NotificationRobotViewComponent(IRobotToBeMaintainedService robotToBeMaintainedManager)
        {
            _robotToBeMaintainedManager = robotToBeMaintainedManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _robotToBeMaintainedManager.GetAll();
            return View("_notificationRobot", result.Data);
        }
    }
}
