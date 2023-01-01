using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.CompleteMaintenanceRobotDtos
{
    public class CompleteMaintenanceRobotDto : DtoGetBase
    {
        public CompleteMaintenanceRobot CompleteMaintenanceRobot { get; set; }
    }
}
