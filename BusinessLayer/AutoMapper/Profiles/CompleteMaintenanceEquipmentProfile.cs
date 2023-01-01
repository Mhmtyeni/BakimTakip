using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class CompleteMaintenanceEquipmentProfile : Profile
    {
        public CompleteMaintenanceEquipmentProfile()
        {
            CreateMap<CompleteMaintenanceEquipmentAddDto, CompleteMaintenanceEquipment>();
            CreateMap<CompleteMaintenanceEquipmentUpdateDto, CompleteMaintenanceEquipment>();
        }
    }
}
