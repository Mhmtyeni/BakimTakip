using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDepartmentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class FactoryDepartmentProfile : Profile
    {
        public FactoryDepartmentProfile()
        {
            CreateMap<FactoryDepartmentAddDto, FactoryDepartment>();
            CreateMap<FactoryDepartmentUpdateDto, FactoryDepartment>();
        }
    }
}
