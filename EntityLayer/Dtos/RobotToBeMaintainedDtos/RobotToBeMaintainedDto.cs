using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotToBeMaintainedDtos
{
    public class RobotToBeMaintainedDto : DtoGetBase
    {
        public RobotToBeMaintained RobotToBeMaintained { get; set; }
    }
}
