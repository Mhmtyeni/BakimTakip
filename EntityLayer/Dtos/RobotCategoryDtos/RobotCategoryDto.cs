using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotCategoryDtos
{
    public class RobotCategoryDto : DtoGetBase
    {
        public RobotCategory RobotCategory { get; set; }
    }
}
