using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentDtos
{
    public class EquipmentListDto:DtoGetBase
    {
        public IList<Equipment> Equipments { get; set; }
    }
}
