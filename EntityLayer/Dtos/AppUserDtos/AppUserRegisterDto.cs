using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
    }
}
