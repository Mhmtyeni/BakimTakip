using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotMaintenanceDtos;
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
    public class RobotMaintenanceManager : ManagerBase, IRobotMaintenanceService
    {
        public RobotMaintenanceManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(RobotMaintenanceAddDto robotMaintenanceAddDto)
        {
            var robotMaintenance = Mapper.Map<RobotMaintenance>(robotMaintenanceAddDto);
            await UnitOfWork.RobotMaintenance.AddAsync(robotMaintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int robotMaintenanceId)
        {
            var result = await UnitOfWork.RobotMaintenance.AnyAsync(a => a.Id == robotMaintenanceId);
            if (result)
            {
                var robotMaintenance = await UnitOfWork.RobotMaintenance.GetAsync(a => a.Id == robotMaintenanceId);
                robotMaintenance.IsActive = false;
                robotMaintenance.IsDeleted = true;
                await UnitOfWork.RobotMaintenance.UpdateAsync(robotMaintenance);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.");
        }
        public async Task<IResult> DeleteByMaintenanceId(int maintenanceId)
        {
            var result = await UnitOfWork.RobotMaintenance.GetAsync(a => a.MaintenanceId == maintenanceId);

            if (result != null)
            {
                var robotMaintenance = await UnitOfWork.RobotMaintenance.GetAsync(a => a.Id == result.Id);
                robotMaintenance.IsActive = false;
                robotMaintenance.IsDeleted = true;
                await UnitOfWork.RobotMaintenance.UpdateAsync(robotMaintenance);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.");
        }

        public async Task<IDataResult<RobotMaintenanceListDto>> GetAll()
        {
            IQueryable<RobotMaintenance> query = UnitOfWork.RobotMaintenance.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.Robot);
            var robotMaintenances = await query.ToListAsync();
            if (robotMaintenances != null)
            {
                return new DataResult<RobotMaintenanceListDto>(ResultStatus.Success, new RobotMaintenanceListDto
                {
                    RobotMaintenances = robotMaintenances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotMaintenanceListDto>(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.", null);
        }

        public async Task<IDataResult<RobotMaintenanceListDto>> GetAllMaintenance(int robotId)
        {
            IQueryable<RobotMaintenance> query = UnitOfWork.RobotMaintenance.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false && x.RobotId == robotId).
                Include(x => x.Robot);
            var robotMaintenances = await query.ToListAsync();
            if (robotMaintenances != null)
            {
                return new DataResult<RobotMaintenanceListDto>(ResultStatus.Success, new RobotMaintenanceListDto
                {
                    RobotMaintenances = robotMaintenances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotMaintenanceListDto>(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.", null);
        }

        public async Task<IDataResult<RobotMaintenanceDto>> GetById(int robotMaintenanceId)
        {
            var robotMaintenance = await UnitOfWork.RobotMaintenance.GetAsync(x => x.Id == robotMaintenanceId);
            if (robotMaintenance != null)
            {
                return new DataResult<RobotMaintenanceDto>(ResultStatus.Success, new RobotMaintenanceDto
                {
                    RobotMaintenance = robotMaintenance,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotMaintenanceDto>(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.", null);
        }

        public async Task<IDataResult<RobotMaintenanceListDto>> GetRobotCategoryId(int robotCategoryId)
        {
            IQueryable<RobotMaintenance> query = UnitOfWork.RobotMaintenance.GetAsQueryable();
            query = query.Where(x => x.RobotId == robotCategoryId && x.IsActive == true && x.IsDeleted == false);
            var robotMaintenances = await query.ToListAsync();
            if (robotMaintenances != null)
            {
                return new DataResult<RobotMaintenanceListDto>(ResultStatus.Success, new RobotMaintenanceListDto
                {
                    RobotMaintenances = robotMaintenances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotMaintenanceListDto>(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.", null);
        }
        public async Task<IDataResult<RobotMaintenanceListDto>> GetRobotId(int robotId)
        {
            IQueryable<RobotMaintenance> query = UnitOfWork.RobotMaintenance.GetAsQueryable();
            query = query.Where(x => x.RobotId == robotId && x.IsActive == true && x.IsDeleted == false);
            var robotMaintenances = await query.ToListAsync();
            if (robotMaintenances != null)
            {
                return new DataResult<RobotMaintenanceListDto>(ResultStatus.Success, new RobotMaintenanceListDto
                {
                    RobotMaintenances = robotMaintenances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotMaintenanceListDto>(ResultStatus.Error, "Böyle bir robot bakımı bulunamadı.", null);
        }

        public async Task<IResult> Update(RobotMaintenanceUpdateDto robotMaintenanceUpdateDto)
        {
            var robotMaintenance = Mapper.Map<RobotMaintenance>(robotMaintenanceUpdateDto);
            await UnitOfWork.RobotMaintenance.UpdateAsync(robotMaintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckRobotMaintenanceExist(int maintenanceId, int robotId)
        {
            return await UnitOfWork.RobotMaintenance.AnyAsync(x => x.MaintenanceId == maintenanceId && x.RobotId == robotId);
        }
    }
}
