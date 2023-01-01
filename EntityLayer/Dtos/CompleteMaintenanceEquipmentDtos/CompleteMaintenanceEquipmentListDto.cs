using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos
{
    public class CompleteMaintenanceEquipmentListDto : DtoGetBase
    {
        public IList<CompleteMaintenanceEquipment> CompleteMaintenanceEquipment { get; set; }
    }
}
