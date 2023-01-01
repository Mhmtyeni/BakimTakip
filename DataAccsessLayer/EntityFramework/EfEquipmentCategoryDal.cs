using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsessLayer.EntityFramework
{
    public class EfEquipmentCategoryDal : EfGenericRepository<EquipmentCategory>, IEquipmentCategoryDal
    {
        public EfEquipmentCategoryDal(DbContext context) : base(context)
        {
        }
    }
}
