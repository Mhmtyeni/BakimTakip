using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.RobotCategoryDtos
{
    public class RobotCategoryListDto : DtoGetBase
    {
        public IList<RobotCategory> RobotCategories { get; set; }
    }
}
