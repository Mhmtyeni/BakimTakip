﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectResponsibleDtos
{
    public class ProjectResponsibleUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual DateTime CreatedDate { get; set; } 
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
