using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectReportProfile : Profile
    {
        public ProjectReportProfile()
        {
            CreateMap<ProjectReportAddDto, ProjectReport>();
            CreateMap<ProjectReportUpdateDto, ProjectReport>();
        }
    }
}
