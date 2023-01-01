using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsessLayer.EntityFramework
{
    public class EfRobotToBeMaintainedDal : EfGenericRepository<RobotToBeMaintained>, IRobotToBeMaintainedDal
    {
        public EfRobotToBeMaintainedDal(DbContext context) : base(context)
        {
        }
    }
}
