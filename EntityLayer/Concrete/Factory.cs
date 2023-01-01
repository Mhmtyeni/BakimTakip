using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Factory : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<FactoryDepartment> FactoryDepartments { get; set; }
    }
}
