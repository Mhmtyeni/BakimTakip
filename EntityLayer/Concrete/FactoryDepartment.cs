using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class FactoryDepartment : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        public ICollection<Project> Projects { get; set; }
    }

}
