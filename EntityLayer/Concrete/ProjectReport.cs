using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjectReport : EntityBase, IEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Fault { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; }
    }
}
