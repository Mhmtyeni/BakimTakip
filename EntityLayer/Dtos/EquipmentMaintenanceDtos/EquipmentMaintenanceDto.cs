using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentMaintenanceDtos
{
    public class EquipmentMaintenanceDto : DtoGetBase
    {
        public EquipmentMaintenance EquipmentMaintenance { get; set; }
    }
}
