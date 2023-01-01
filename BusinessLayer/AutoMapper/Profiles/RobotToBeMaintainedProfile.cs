using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotToBeMaintainedDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class RobotToBeMaintainedProfile : Profile
    {
        public RobotToBeMaintainedProfile()
        {
            CreateMap<RobotToBeMaintainedAddDto, RobotToBeMaintained>();
            CreateMap<RobotToBeMaintainedUpdateDto, RobotToBeMaintained>();
        }
    }
}
