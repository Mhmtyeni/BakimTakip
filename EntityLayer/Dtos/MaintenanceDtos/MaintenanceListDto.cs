using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.MaintenanceDtos
{
    public class MaintenanceListDto : DtoGetBase
    {
        public IList<Maintenance> Maintenances { get; set; }
    }
}
