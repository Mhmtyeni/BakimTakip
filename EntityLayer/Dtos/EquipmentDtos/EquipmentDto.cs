using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentDtos
{
    public class EquipmentDto : DtoGetBase
    {
        public Equipment Equipment { get; set; }    
    }
}
