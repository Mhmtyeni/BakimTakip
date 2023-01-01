using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class CompleteMaintenanceEquipment : EntityBase, IEntity
    {
        public int ProjectEquipmentId { get; set; }
        public ProjectEquipment ProjectEquipment { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime MaintenanceDate { get; set; }
    }
}
