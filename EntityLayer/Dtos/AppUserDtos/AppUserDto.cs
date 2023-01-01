using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.AppUserDtos
{
    public class AppUserDto : DtoGetBase
    {
        public AppUser AppUser { get; set; }
    }
}
