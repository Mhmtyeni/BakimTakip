using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectAddDto, Project>();
            CreateMap<ProjectUpdateDto, Project>();
        }
    }
}
