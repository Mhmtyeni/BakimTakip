using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Robot : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int RobotCategoryId { get; set; }
        public RobotCategory RobotCategory { get; set; }
        public ICollection<ProjectRobot> ProjectRobots { get; set; }
        public ICollection<RobotMaintenance> RobotMaintenances { get; set; }
    }
}
