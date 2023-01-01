using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotMaintenanceDtos
{
    public class RobotMaintenanceListDto : DtoGetBase
    {
        public IList<RobotMaintenance> RobotMaintenances { get; set; }
    }
}
