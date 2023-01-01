using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Equipment:EntityBase,IEntity
    {
        public string Name { get; set; }
        public int Period { get; set; }
        public string MaintenanceName { get; set; }
        public string MaintenanceComment { get; set; }
        public int EquipmentCategoryId { get; set; }
        public EquipmentCategory EquipmentCategory { get; set; }
        public ICollection<ProjectEquipment> ProjectEquipment { get; set; }
    }
}
