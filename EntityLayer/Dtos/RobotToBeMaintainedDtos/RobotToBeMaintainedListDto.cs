using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotToBeMaintainedDtos
{
    public class RobotToBeMaintainedListDto : DtoGetBase
    {
        public IList<RobotToBeMaintained> RobotToBeMaintained { get; set; }
    }
}
