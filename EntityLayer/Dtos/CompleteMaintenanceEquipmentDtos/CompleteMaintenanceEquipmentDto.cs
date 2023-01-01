using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos
{
    public class CompleteMaintenanceEquipmentDto : DtoGetBase
    {
        public CompleteMaintenanceEquipment CompleteMaintenanceEquipment { get; set; }
    }
}
