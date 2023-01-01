using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class ProjectRobot : EntityBase, IEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int RobotId { get; set; }
        public Robot Robot { get; set; }
        public ICollection<CompleteMaintenanceRobot> CompleteMaintenanceRobots { get; set; }
        public ICollection<RobotToBeMaintained> RobotToBeMaintaineds { get; set; }
        public ICollection<RobotToBeMaintainedUser> RobotToBeMaintainedUsers { get; set; }
    }
}
