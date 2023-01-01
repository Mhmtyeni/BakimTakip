using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.FaultReportDtos
{
    public class FaultReportUpdateDto
    {
        public int Id { get; set; }
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
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
