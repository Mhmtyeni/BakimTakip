using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class FactoryProfile : Profile
    {
        public FactoryProfile()
        {
            CreateMap<FactoryAddDto, Factory>();
            CreateMap<FactoryUpdateDto, Factory>();
        }
    }
}
