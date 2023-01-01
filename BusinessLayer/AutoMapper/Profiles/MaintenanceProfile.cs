using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.MaintenanceDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class MaintenanceProfile : Profile
    {
        public MaintenanceProfile()
        {
            CreateMap<MaintenanceAddDto, Maintenance>();
            CreateMap<MaintenanceUpdateDto, Maintenance>();
        }
    }
}
