using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectEquipmentDtos
{
    public class ProjectEquipmentAddDto
    {
        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public bool CheckMaintenance { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
