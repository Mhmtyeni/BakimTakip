using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUserDto, AppUser>();
        }
    }
}
