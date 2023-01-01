using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.FaultReportDtos
{
    public class FaultReportListDto : DtoGetBase
    {
        public IList<FaultReport> FaultReports { get; set; }
    }
}
