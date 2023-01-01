using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentMaintenanceDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class EquipmentMaintenanceProfile : Profile
    {
        public EquipmentMaintenanceProfile()
        {
            CreateMap<EquipmentMaintenanceAddDto, EquipmentMaintenance>();
            CreateMap<EquipmentMaintenanceUpdateDto, EquipmentMaintenance>();
        }
    }
}
