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
    public class EfProjectReportDal : EfGenericRepository<ProjectReport>, IProjectReportDal
    {
        public EfProjectReportDal(DbContext context) : base(context)
        {
        }
    }
}
