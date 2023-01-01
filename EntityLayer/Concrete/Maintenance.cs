using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Maintenance : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int Period { get; set; }
        public string MaintenanceComment { get; set; }
        public ICollection<RobotMaintenance> RobotMaintenances { get; set; }
    }
}
