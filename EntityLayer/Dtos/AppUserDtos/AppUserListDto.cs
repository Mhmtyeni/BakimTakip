using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.AppUserDtos
{
    public class AppUserListDto : DtoGetBase
    {
        public IList<AppUser> AppUsers { get; set; }
    }
}
