using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Models
{
    public class HomeIndexViewModel
    {
        public int TotalProject { get; set; }
        public int TotalRobot { get; set; }
        public int TotalEquipment { get; set; }
        public int TotalCompleteMaintenance { get; set; }
        public string[] EquipmentMaintenance = new string[10],RobotMaintenance = new string[10],EquipmentMaintenanceUser = new string[10], RobotMaintenanceUser = new string[10];
    }
}
