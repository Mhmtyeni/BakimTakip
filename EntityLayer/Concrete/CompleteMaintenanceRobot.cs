using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class CompleteMaintenanceRobot : EntityBase, IEntity
    {
        public int ProjectRobotId { get; set; }
        public ProjectRobot ProjectRobot { get; set; }
        public int? RobotMaintenanceId { get; set; }
        public RobotMaintenance RobotMaintenance { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime MaintenanceDate { get; set; }
    }
}
