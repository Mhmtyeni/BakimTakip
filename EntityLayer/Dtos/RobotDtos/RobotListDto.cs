using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotDtos
{
    public class RobotListDto : DtoGetBase
    {
        public IList<Robot> Robots { get; set; }
    }
}
