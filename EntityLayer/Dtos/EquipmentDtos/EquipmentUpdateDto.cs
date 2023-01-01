using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentDtos
{
    public class EquipmentUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Period { get; set; }
        public string MaintenanceName { get; set; }
        public string MaintenanceComment { get; set; }
        public int EquipmentCategoryId { get; set; }
        public virtual EquipmentCategory EquipmentCategory { get; set; }
        public virtual DateTime CreatedDate { get; set; } 
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
