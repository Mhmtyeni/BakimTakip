using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;
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
    public class CompleteMaintenanceRobotManager : ManagerBase, ICompleteMaintenanceRobotService
    {
        public CompleteMaintenanceRobotManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(CompleteMaintenanceRobotAddDto completeMaintenanceRobotAddDto)
        {
            var completeMaintenanceRobot = Mapper.Map<CompleteMaintenanceRobot>(completeMaintenanceRobotAddDto);
            await UnitOfWork.CompleteMaintenanceRobot.AddAsync(completeMaintenanceRobot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int completeMaintenanceRobotId)
        {
            var result = await UnitOfWork.CompleteMaintenanceRobot.AnyAsync(a => a.Id == completeMaintenanceRobotId);
            if (result)
            {
                var completeMaintenanceRobot = await UnitOfWork.CompleteMaintenanceRobot.GetAsync(a => a.Id == completeMaintenanceRobotId);
                completeMaintenanceRobot.IsActive = false;
                completeMaintenanceRobot.IsDeleted = true;
                await UnitOfWork.CompleteMaintenanceRobot.UpdateAsync(completeMaintenanceRobot);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Bakımı tanımlanmış robot bulunamadı.");
        }

        public async Task<IDataResult<CompleteMaintenanceRobotListDto>> GetAll()
        {
            IQueryable<CompleteMaintenanceRobot> query = UnitOfWork.CompleteMaintenanceRobot.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.AppUser).
                Include(x => x.ProjectRobot).
                Include(x => x.RobotMaintenance);
            var completeMaintenanceRobot = await query.ToListAsync();
            if (completeMaintenanceRobot != null)
            {
                return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Success, new CompleteMaintenanceRobotListDto
                {
                    CompleteMaintenanceRobots = completeMaintenanceRobot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Error, "Bakımı tanımlanmış robot bulunamadı.", null);
        }
        public async Task<IDataResult<CompleteMaintenanceRobotListDto>> GetAllMounth()
        {
            IQueryable<CompleteMaintenanceRobot> query = UnitOfWork.CompleteMaintenanceRobot.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false && x.MaintenanceDate.Month == DateTime.Now.Month).
                Include(x => x.AppUser).
                Include(x => x.ProjectRobot).
                Include(x => x.RobotMaintenance);
            var completeMaintenanceRobot = await query.ToListAsync();
            if (completeMaintenanceRobot != null)
            {
                return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Success, new CompleteMaintenanceRobotListDto
                {
                    CompleteMaintenanceRobots = completeMaintenanceRobot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Error, "Bakımı tanımlanmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<CompleteMaintenanceRobotDto>> GetById(int completeMaintenanceRobotId)
        {
            var completeMaintenanceRobot = await UnitOfWork.CompleteMaintenanceRobot.GetAsync(x => x.Id == completeMaintenanceRobotId);
            if (completeMaintenanceRobot != null)
            {
                return new DataResult<CompleteMaintenanceRobotDto>(ResultStatus.Success, new CompleteMaintenanceRobotDto
                {
                    CompleteMaintenanceRobot = completeMaintenanceRobot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceRobotDto>(ResultStatus.Error, "Bakımı tanımlanmış robot bulunamadı.", null);
        }

        public async Task<IDataResult<CompleteMaintenanceRobotListDto>> GetByProjectRobotId(int projectRobotId)
        {
            IQueryable<CompleteMaintenanceRobot> query = UnitOfWork.CompleteMaintenanceRobot.GetAsQueryable();
            query = query.Where(x => x.ProjectRobotId == projectRobotId && x.IsActive == true && x.IsDeleted == false);
            var completeMaintenanceRobot = await query.ToListAsync();
            if (completeMaintenanceRobot != null)
            {
                return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Success, new CompleteMaintenanceRobotListDto
                {
                    CompleteMaintenanceRobots = completeMaintenanceRobot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceRobotListDto>(ResultStatus.Error, "Bakımı tanımlanmış robot bulunamadı.", null);
        }

        public async Task<IResult> Update(CompleteMaintenanceRobotUpdateDto completeMaintenanceRobotUpdateDto)
        {
            var completeMaintenanceRobot = Mapper.Map<CompleteMaintenanceRobot>(completeMaintenanceRobotUpdateDto);
            await UnitOfWork.CompleteMaintenanceRobot.UpdateAsync(completeMaintenanceRobot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
