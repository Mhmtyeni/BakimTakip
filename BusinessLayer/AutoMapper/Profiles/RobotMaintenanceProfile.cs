using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotMaintenanceDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class RobotMaintenanceProfile : Profile
    {
        public RobotMaintenanceProfile()
        {
            CreateMap<RobotMaintenanceAddDto, RobotMaintenance>();
            CreateMap<RobotMaintenanceUpdateDto, RobotMaintenance>();
        }
    }
}
