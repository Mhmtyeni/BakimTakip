using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectEquipmentDtos
{
    public class ProjectEquipmentListDto : DtoGetBase
    {
        public IList<ProjectEquipment> ProjectEquipment { get; set; }
    }
}
