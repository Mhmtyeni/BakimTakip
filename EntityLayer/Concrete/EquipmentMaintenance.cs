using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class EquipmentMaintenance:EntityBase,IEntity
    {
        public int ProjectEquipmentId { get; set; }
        public ProjectEquipment ProjectEquipment { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public bool DoneOrNotDone { get; set; }
    }
}
