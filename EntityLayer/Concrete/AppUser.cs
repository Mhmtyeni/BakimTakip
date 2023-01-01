using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ProjectResponsible> ProjectResponsibles { get; set; }
        public ICollection<CompleteMaintenanceEquipment> CompleteMaintenanceEquipment { get; set; }
        public ICollection<CompleteMaintenanceRobot> CompleteMaintenanceRobots { get; set; }
        public ICollection<FaultReport> FaultReports { get; set; }
        public ICollection<ProjectReport> ProjectReports { get; set; }
    }
}
