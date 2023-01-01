using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectDtos
{
    public class ProjectListDto : DtoGetBase
    {
        public IList<Project> Projects { get; set; }
    }
}
