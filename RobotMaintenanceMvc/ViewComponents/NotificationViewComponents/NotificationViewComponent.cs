using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.NotificationViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {

        private readonly IEquipmentMaintenanceService _equipmentMaintenanceManager;

        public NotificationViewComponent(IEquipmentMaintenanceService equipmentMaintenanceManager)
        {
            _equipmentMaintenanceManager = equipmentMaintenanceManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _equipmentMaintenanceManager.GetAll();
            return View("_notification", result.Data);
        }
    }
}
