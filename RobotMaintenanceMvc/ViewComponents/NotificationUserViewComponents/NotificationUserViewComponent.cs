using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.NotificationUserViewComponents
{
    public class NotificationUserViewComponent : ViewComponent
    {

        private readonly IEquipmentMaintenanceUserService _equipmentMaintenanceUserManager;

        public NotificationUserViewComponent(IEquipmentMaintenanceUserService equipmentMaintenanceUserManager)
        {
            _equipmentMaintenanceUserManager = equipmentMaintenanceUserManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _equipmentMaintenanceUserManager.GetAll();
            return View("_notificationUser", result.Data);
        }
    }
}
