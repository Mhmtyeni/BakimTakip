using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.EquipmentMaintenanceUserDtos
{
    public class EquipmentMaintenanceUserDto : DtoGetBase
    {
        public EquipmentMaintenanceUser EquipmentMaintenanceUser { get; set; }
    }
}
