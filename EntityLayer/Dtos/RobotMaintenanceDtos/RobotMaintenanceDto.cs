using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotMaintenanceDtos
{
    public class RobotMaintenanceDto:DtoGetBase
    {
        public RobotMaintenance RobotMaintenance { get; set; }
    }
}
