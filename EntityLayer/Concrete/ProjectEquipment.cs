using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class ProjectEquipment : EntityBase, IEntity
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public bool CheckMaintenance { get; set; }
        public ICollection<CompleteMaintenanceEquipment> CompleteMaintenanceEquipment { get; set; }
        public ICollection<EquipmentMaintenance> EquipmentMaintenances { get; set; }
        public ICollection<EquipmentMaintenanceUser> EquipmentMaintenanceUsers { get; set; }
        
    }
}
