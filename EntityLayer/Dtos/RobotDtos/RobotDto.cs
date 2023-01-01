using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotDtos
{
    public class RobotDto : DtoGetBase
    {
        public Robot Robot { get; set; }
    }
}
