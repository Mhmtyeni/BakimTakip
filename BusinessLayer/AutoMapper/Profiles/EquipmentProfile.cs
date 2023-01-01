using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<EquipmentAddDto, Equipment>();
            CreateMap<EquipmentUpdateDto, Equipment>();
        }
    }
}
