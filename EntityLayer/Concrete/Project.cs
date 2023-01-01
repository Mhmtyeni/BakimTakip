using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Project : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int FactoryDepartmentId { get; set; }
        public FactoryDepartment FactoryDepartment { get; set; }
        public ICollection<ProjectResponsible> ProjectResponsibles { get; set; }
        public ICollection<ProjectRobot> ProjectRobots { get; set; }
        public ICollection<ProjectEquipment> ProjectEquipment { get; set; }
        public ICollection<FaultReport> FaultReports { get; set; }
        public ICollection<ProjectReport> ProjectReports { get; set; }
    }
}
