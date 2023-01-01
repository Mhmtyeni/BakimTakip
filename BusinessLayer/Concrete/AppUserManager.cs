using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.AppUserDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : ManagerBase, IAppUserService
    {
        public AppUserManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<AppUserListDto>> GetAll()
        {
            IQueryable<AppUser> query = UnitOfWork.AppUser.GetAsQueryable();
            query = query.Where(x => x.FirstName != null);
            var appUsers = await query.ToListAsync();
            if (appUsers != null)
            {
                return new DataResult<AppUserListDto>(ResultStatus.Success, new AppUserListDto
                {
                    AppUsers = appUsers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppUserListDto>(ResultStatus.Error, "Böyle bir kullanıcı bulunamadı.", null);
        }

        public Task<IDataResult<AppUserDto>> GetByUserName()
        {
            throw new NotImplementedException();
        }
    }
}
