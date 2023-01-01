using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RobotToBeMaintainedUser : EntityBase, IEntity
    {
        public int? ProjectRobotId { get; set; }
        public ProjectRobot ProjectRobot { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int RobotMaintenanceId { get; set; }
        public RobotMaintenance RobotMaintenance { get; set; }
        public bool DoneOrNotDone { get; set; }
        public bool CheckOrDenied { get; set; }
    }
}
