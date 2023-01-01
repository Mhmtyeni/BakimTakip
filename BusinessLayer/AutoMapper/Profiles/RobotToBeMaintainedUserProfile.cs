using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class RobotToBeMaintainedUserProfile : Profile
    {
        public RobotToBeMaintainedUserProfile()
        {
            CreateMap<RobotToBeMaintainedUserAddDto, RobotToBeMaintainedUser>();
            CreateMap<RobotToBeMaintainedUserUpdateDto, RobotToBeMaintainedUser>();
        }
    }
}
