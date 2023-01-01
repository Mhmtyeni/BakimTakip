using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectResponsibleDtos
{
    public class ProjectResponsibleListDto:DtoGetBase
    {
        public IList<ProjectResponsible> ProjectResponsibles { get; set; }
    }
}
