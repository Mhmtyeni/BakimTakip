using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.FactoryDepartmentDtos
{
    public class FactoryDepartmentListDto : DtoGetBase
    {
        public IList<FactoryDepartment> FactoryDepartments { get; set; }
    }
}
