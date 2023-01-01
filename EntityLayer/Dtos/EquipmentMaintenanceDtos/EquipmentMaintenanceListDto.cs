using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.EquipmentMaintenanceDtos
{
    public class EquipmentMaintenanceListDto : DtoGetBase
    {
        public IList<EquipmentMaintenance> EquipmentMaintenances { get; set; }
    }
}
