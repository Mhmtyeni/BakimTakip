﻿using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class EquipmentMaintenanceUserProfile : Profile
    {
        public EquipmentMaintenanceUserProfile()
        {
            CreateMap<EquipmentMaintenanceUserAddDto, EquipmentMaintenanceUser>();
            CreateMap<EquipmentMaintenanceUserUpdateDto, EquipmentMaintenanceUser>();
        }
    }
}
