using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentCategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class EquipmentCategoryProfile : Profile
    {
        public EquipmentCategoryProfile()
        {
            CreateMap<EquipmentCategoryAddDto, EquipmentCategory>();
            CreateMap<EquipmentCategoryUpdateDto, EquipmentCategory>();
        }
    }
}
