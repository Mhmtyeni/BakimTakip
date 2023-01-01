using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class CompleteMaintenanceRobotProfile : Profile
    {
        public CompleteMaintenanceRobotProfile()
        {
            CreateMap<CompleteMaintenanceRobotAddDto, CompleteMaintenanceRobot>();
            CreateMap<CompleteMaintenanceRobotUpdateDto, CompleteMaintenanceRobot>();
        }
    }
}
