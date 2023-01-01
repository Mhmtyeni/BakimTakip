using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.ProjectRobotDtos
{
    public class ProjectRobotListDto : DtoGetBase
    {
        public IList<ProjectRobot> ProjectRobots { get; set; }
    }
}
