using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotCategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class RobotCategoryProfile:Profile
    {
        public RobotCategoryProfile()
        {
            CreateMap<RobotCategoryAddDto, RobotCategory>();
            CreateMap<RobotCategoryUpdateDto, RobotCategory>();
        }
    }
}
