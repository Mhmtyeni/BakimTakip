using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class EquipmentCategory : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int SubId { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
