using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsessLayer.EntityFramework
{
    public class EfEquipmentDal : EfGenericRepository<Equipment>, IEquipmentDal
    {
        public EfEquipmentDal(DbContext context) : base(context)
        {
        }
    }
}
