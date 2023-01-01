using EntityLayer.Dtos.AppUserDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAppUserService
    {
        public Task<IDataResult<AppUserListDto>> GetAll();
        public Task<IDataResult<AppUserDto>> GetByUserName();
    }
}
