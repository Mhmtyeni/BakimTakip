using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FaultReport : EntityBase, IEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Fault { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline1 { get; set; }
        public DateTime Deadline2 { get; set; }
        public DateTime Deadline3 { get; set; }
        public bool Completed { get; set; }

    }
}
