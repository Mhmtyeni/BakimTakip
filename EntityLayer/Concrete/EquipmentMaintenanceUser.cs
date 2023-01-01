using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EquipmentMaintenanceUser : EntityBase, IEntity
    {
        public int ProjectEquipmentId { get; set; }
        public ProjectEquipment ProjectEquipment { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public bool DoneOrNotDone { get; set; }
        public bool CheckOrDenied { get; set; }
    }
}
