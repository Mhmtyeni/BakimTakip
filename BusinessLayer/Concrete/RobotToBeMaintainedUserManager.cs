using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;
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
    public class RobotToBeMaintainedUserManager : ManagerBase, IRobotToBeMaintainedUserService
    {
        public RobotToBeMaintainedUserManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(RobotToBeMaintainedUserAddDto robotToBeMaintainedUserAddDto)
        {
            var robotToBeMaintained = Mapper.Map<RobotToBeMaintainedUser>(robotToBeMaintainedUserAddDto);
            await UnitOfWork.RobotToBeMaintainedUser.AddAsync(robotToBeMaintained);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<bool> CheckProjectRobotExist(int projectRobotId, int robotMaintenanceId)
        {
            return await UnitOfWork.RobotToBeMaintainedUser.AnyAsync(x => x.ProjectRobotId == projectRobotId && x.RobotMaintenanceId == robotMaintenanceId);
        }

        public async Task<IResult> DeleteById(int robotToBeMaintainedUserId)
        {
            var result = await UnitOfWork.RobotToBeMaintainedUser.AnyAsync(a => a.Id == robotToBeMaintainedUserId);
            if (result)
            {
                var robotToBeMaintainedUser = await UnitOfWork.RobotToBeMaintained.GetAsync(a => a.Id == robotToBeMaintainedUserId);
                robotToBeMaintainedUser.IsActive = false;
                robotToBeMaintainedUser.IsDeleted = true;
                await UnitOfWork.RobotToBeMaintained.UpdateAsync(robotToBeMaintainedUser);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.");
        }

        public async Task<IDataResult<RobotToBeMaintainedUserListDto>> GetAll()
        {
            IQueryable<RobotToBeMaintainedUser> query = UnitOfWork.RobotToBeMaintainedUser.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.ProjectRobot).ThenInclude(x => x.Project)
                .Include(x => x.RobotMaintenance).ThenInclude(x => x.Maintenance)
                .Include(x => x.RobotMaintenance).ThenInclude(x => x.Robot).OrderByDescending(x => x.ModifiedDate);
            var robotToBeMaintainedUsers = await query.ToListAsync();
            if (robotToBeMaintainedUsers != null)
            {
                return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Success, new RobotToBeMaintainedUserListDto
                {
                    RobotToBeMaintainedUsers = robotToBeMaintainedUsers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedUserDto>> GetById(int robotToBeMaintainedUserId)
        {
            var robotToBeMaintainedUser = await UnitOfWork.RobotToBeMaintainedUser.GetAsync(x => x.Id == robotToBeMaintainedUserId,x=>x.ProjectRobot.Project,x=>x.RobotMaintenance.Robot);
            if (robotToBeMaintainedUser != null)
            {
                return new DataResult<RobotToBeMaintainedUserDto>(ResultStatus.Success, new RobotToBeMaintainedUserDto
                {
                    RobotToBeMaintainedUser = robotToBeMaintainedUser,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedUserDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedUserListDto>> GetByProjectRobotId(int projectRobotId)
        {
            IQueryable<RobotToBeMaintainedUser> query = UnitOfWork.RobotToBeMaintainedUser.GetAsQueryable();
            query = query.Where(x => x.ProjectRobotId == projectRobotId && x.IsActive == true && x.IsDeleted == false);
            var robotToBeMaintainedUsers = await query.ToListAsync();
            if (robotToBeMaintainedUsers != null)
            {
                return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Success, new RobotToBeMaintainedUserListDto
                {
                    RobotToBeMaintainedUsers = robotToBeMaintainedUsers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedUserListDto>> GetByRobotMaintenanceId(int robotMaintenanceId)
        {
            IQueryable<RobotToBeMaintainedUser> query = UnitOfWork.RobotToBeMaintainedUser.GetAsQueryable();
            query = query.Where(x => x.RobotMaintenanceId == robotMaintenanceId && x.IsActive == true && x.IsDeleted == false);
            var robotToBeMaintainedUsers = await query.ToListAsync();
            if (robotToBeMaintainedUsers != null)
            {
                return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Success, new RobotToBeMaintainedUserListDto
                {
                    RobotToBeMaintainedUsers = robotToBeMaintainedUsers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedUserListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IResult> Update(RobotToBeMaintainedUserUpdateDto robotToBeMaintainedUserUpdateDto)
        {
            var robotToBeMaintainedUser = Mapper.Map<RobotToBeMaintainedUser>(robotToBeMaintainedUserUpdateDto);
            await UnitOfWork.RobotToBeMaintainedUser.UpdateAsync(robotToBeMaintainedUser);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
