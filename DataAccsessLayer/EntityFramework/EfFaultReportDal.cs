using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfFaultReportDal : EfGenericRepository<FaultReport>, IFaultReportDal
    {
        public EfFaultReportDal(DbContext context) : base(context)
        {
        }
    }
}
