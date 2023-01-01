using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsessLayer.EntityFramework
{
    public class EfProjectEquipmentDal : EfGenericRepository<ProjectEquipment>, IProjectEquipmentDal
    {
        public EfProjectEquipmentDal(DbContext context) : base(context)
        {
        }
    }
}
