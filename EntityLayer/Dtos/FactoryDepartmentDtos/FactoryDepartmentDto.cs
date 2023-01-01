using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.FactoryDepartmentDtos
{
    public class FactoryDepartmentDto : DtoGetBase
    {
        public FactoryDepartment FactoryDepartment { get; set; }
    }
}
