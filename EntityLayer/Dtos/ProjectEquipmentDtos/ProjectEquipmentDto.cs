using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectEquipmentDtos
{
    public class ProjectEquipmentDto : DtoGetBase
    {
        public ProjectEquipment ProjectEquipment { get; set; }
    }
}
