using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectRobotDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectRobotProfile:Profile
    {
        public ProjectRobotProfile()
        {
            CreateMap<ProjectRobotAddDto, ProjectRobot>();
            CreateMap<ProjectRobotUpdateDto, ProjectRobot>();
        }
    }
}
