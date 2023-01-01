using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotToBeMaintainedDtos;
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
    public class RobotToBeMaintainedManager : ManagerBase, IRobotToBeMaintainedService
    {
        public RobotToBeMaintainedManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(RobotToBeMaintainedAddDto robotToBeMaintainedAddDto)
        {
            var robotToBeMaintained = Mapper.Map<RobotToBeMaintained>(robotToBeMaintainedAddDto);
            await UnitOfWork.RobotToBeMaintained.AddAsync(robotToBeMaintained);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int robotToBeMaintainedId)
        {
            var result = await UnitOfWork.RobotToBeMaintained.AnyAsync(a => a.Id == robotToBeMaintainedId);
            if (result)
            {
                var robotToBeMaintained = await UnitOfWork.RobotToBeMaintained.GetAsync(a => a.Id == robotToBeMaintainedId);
                robotToBeMaintained.IsActive = false;
                robotToBeMaintained.IsDeleted = true;
                await UnitOfWork.RobotToBeMaintained.UpdateAsync(robotToBeMaintained);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.");
        }

        public async Task<IDataResult<RobotToBeMaintainedListDto>> GetAll()
        {
            IQueryable<RobotToBeMaintained> query = UnitOfWork.RobotToBeMaintained.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.ProjectRobot).ThenInclude(x=>x.Project)
                .Include(x => x.RobotMaintenance).ThenInclude(x => x.Maintenance)
                .Include(x => x.RobotMaintenance).ThenInclude(x => x.Robot).OrderByDescending(x => x.ModifiedDate);
            var robotToBeMaintaineds = await query.ToListAsync();
            if (robotToBeMaintaineds != null)
            {
                return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Success, new RobotToBeMaintainedListDto
                {
                    RobotToBeMaintained = robotToBeMaintaineds,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedDto>> GetById(int robotToBeMaintainedId)
        {
            var robotToBeMaintained = await UnitOfWork.RobotToBeMaintained.GetAsync(x => x.Id == robotToBeMaintainedId);
            if (robotToBeMaintained != null)
            {
                return new DataResult<RobotToBeMaintainedDto>(ResultStatus.Success, new RobotToBeMaintainedDto
                {
                    RobotToBeMaintained = robotToBeMaintained,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedListDto>> GetByProjectRobotId(int projectRobotId)
        {
            IQueryable<RobotToBeMaintained> query = UnitOfWork.RobotToBeMaintained.GetAsQueryable();
            query = query.Where(x => x.ProjectRobotId == projectRobotId && x.IsActive == true && x.IsDeleted == false);
            var robotToBeMaintaineds = await query.ToListAsync();
            if (robotToBeMaintaineds != null)
            {
                return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Success, new RobotToBeMaintainedListDto
                {
                    RobotToBeMaintained = robotToBeMaintaineds,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotToBeMaintainedListDto>> GetByRobotMaintenanceId(int robotMaintenanceId)
        {
            IQueryable<RobotToBeMaintained> query = UnitOfWork.RobotToBeMaintained.GetAsQueryable();
            query = query.Where(x => x.RobotMaintenanceId == robotMaintenanceId && x.IsActive == true && x.IsDeleted == false);
            var robotToBeMaintaineds = await query.ToListAsync();
            if (robotToBeMaintaineds != null)
            {
                return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Success, new RobotToBeMaintainedListDto
                {
                    RobotToBeMaintained = robotToBeMaintaineds,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotToBeMaintainedListDto>(ResultStatus.Error, "Bakımı yapılmış robot bulunamadı.", null);
        }

        public async Task<IResult> Update(RobotToBeMaintainedUpdateDto robotToBeMaintainedUpdateDto)
        {
            var robotToBeMaintained = Mapper.Map<RobotToBeMaintained>(robotToBeMaintainedUpdateDto);
            await UnitOfWork.RobotToBeMaintained.UpdateAsync(robotToBeMaintained);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckProjectRobotExist(int projectRobotId)
        {
            return await UnitOfWork.RobotToBeMaintained.AnyAsync(x => x.ProjectRobotId == projectRobotId);
        }
    }
}
