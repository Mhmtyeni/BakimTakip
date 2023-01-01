using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class RobotToBeMaintained : EntityBase, IEntity
    {
        public int? ProjectRobotId { get; set; }
        public ProjectRobot ProjectRobot { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int RobotMaintenanceId { get; set; }
        public RobotMaintenance RobotMaintenance { get; set; }
        public bool DoneOrNotDone { get; set; }
    }
}
