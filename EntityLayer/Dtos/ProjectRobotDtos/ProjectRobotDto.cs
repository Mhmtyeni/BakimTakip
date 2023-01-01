using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectRobotDtos
{
    public class ProjectRobotDto : DtoGetBase
    {
        public ProjectRobot ProjectRobot { get; set; }
    }
}
