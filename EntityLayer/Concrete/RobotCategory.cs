using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class RobotCategory : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<Robot> Robots { get; set; }
    }
}
