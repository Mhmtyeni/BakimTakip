using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectEquipmentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectEquipmentProfile:Profile
    {
        public ProjectEquipmentProfile()
        {
            CreateMap<ProjectEquipmentAddDto, ProjectEquipment>();
            CreateMap<ProjectEquipmentUpdateDto, ProjectEquipment>();
        }
    }
}
