using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class RobotMaintenance : EntityBase, IEntity
    {
        public int RobotId { get; set; }
        public Robot Robot { get; set; }
        public int MaintenanceId { get; set; }
        public Maintenance Maintenance { get; set; }
        public ICollection<CompleteMaintenanceRobot> CompleteMaintenanceRobots { get; set; }
        public ICollection<RobotToBeMaintained> RobotToBeMaintaineds { get; set; }
        public ICollection<RobotToBeMaintainedUser> RobotToBeMaintainedUsers { get; set; }
    }
}
