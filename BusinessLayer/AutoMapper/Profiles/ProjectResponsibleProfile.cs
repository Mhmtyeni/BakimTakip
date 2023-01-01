using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectResponsibleDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectResponsibleProfile : Profile
    {
        public ProjectResponsibleProfile()
        {
            CreateMap<ProjectResponsibleAddDto, ProjectResponsible>();
            CreateMap<ProjectResponsibleUpdateDto, ProjectResponsible>();
        }
    }
}
