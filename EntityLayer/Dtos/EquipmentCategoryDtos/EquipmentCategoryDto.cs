using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentCategoryDtos
{
    public class EquipmentCategoryDto : DtoGetBase
    {
        public EquipmentCategory EquipmentCategory { get; set; }
    }
}
