using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class RobotProfile : Profile
    {
        public RobotProfile()
        {
            CreateMap<RobotAddDto, Robot>();
            CreateMap<RobotUpdateDto, Robot>();
        }
    }
}
