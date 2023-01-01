using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentMaintenanceDtos
{
    public class EquipmentMaintenanceAddDto
    {
        public int ProjectEquipmentId { get; set; }
        public virtual ProjectEquipment ProjectEquipment { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public bool DoneOrNotDone { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
