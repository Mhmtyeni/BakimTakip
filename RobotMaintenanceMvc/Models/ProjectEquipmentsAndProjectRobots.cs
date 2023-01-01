using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Models
{
    public class ProjectEquipmentsAndProjectRobots
    {
        public IEnumerable<ProjectEquipment> ProjectEquipment { get; set; }
        public IEnumerable<ProjectRobot> ProjectRobots { get; set; }
        public IEnumerable<Equipment> Equipment { get; set; }
        public IEnumerable<Robot> Robots { get; set; }
        public int Id { get; set; }
    }
}
