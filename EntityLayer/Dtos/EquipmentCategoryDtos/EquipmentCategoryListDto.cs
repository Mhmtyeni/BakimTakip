using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentCategoryDtos
{
    public class EquipmentCategoryListDto : DtoGetBase
    {
        public IList<EquipmentCategory> EquipmentCategories { get; set; }
    }
}
