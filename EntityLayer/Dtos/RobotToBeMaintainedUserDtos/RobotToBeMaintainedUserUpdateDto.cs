using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.RobotToBeMaintainedUserDtos
{
    public class RobotToBeMaintainedUserUpdateDto
    {
        public int Id { get; set; }
        public int ProjectRobotId { get; set; }
        public virtual ProjectRobot ProjectRobot { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int RobotMaintenanceId { get; set; }
        public virtual RobotMaintenance RobotMaintenance { get; set; }
        public bool DoneOrNotDone { get; set; }
        public bool CheckOrDenied { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
