using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectResponsibleDtos
{
    public class ProjectResponsibleDto : DtoGetBase
    {
        public ProjectResponsible ProjectResponsible { get; set; }
    }
}
