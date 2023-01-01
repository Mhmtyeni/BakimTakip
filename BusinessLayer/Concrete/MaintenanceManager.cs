using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.MaintenanceDtos;
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
    public class MaintenanceManager : ManagerBase, IMaintenanceService
    {
        public MaintenanceManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(MaintenanceAddDto maintenanceAddDto)
        {
            var maintenance = Mapper.Map<Maintenance>(maintenanceAddDto);
            await UnitOfWork.Maintenance.AddAsync(maintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int maintenanceId)
        {
            var result = await UnitOfWork.Maintenance.AnyAsync(a => a.Id == maintenanceId);
            if (result)
            {
                var maintenance = await UnitOfWork.Maintenance.GetAsync(a => a.Id == maintenanceId);
                maintenance.IsActive = false;
                maintenance.IsDeleted = true;
                await UnitOfWork.Maintenance.UpdateAsync(maintenance);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir bakım bulunamadı.");
        }

        public async Task<IDataResult<MaintenanceListDto>> GetAll()
        {
            IQueryable<Maintenance> query = UnitOfWork.Maintenance.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false);
            var maintenances = await query.ToListAsync();
            if (maintenances != null)
            {
                return new DataResult<MaintenanceListDto>(ResultStatus.Success, new MaintenanceListDto
                {
                    Maintenances = maintenances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MaintenanceListDto>(ResultStatus.Error, "Böyle bir bakım bulunamadı.", null);
        }

        public async Task<IDataResult<MaintenanceDto>> GetById(int maintenanceId)
        {
            var maintenance = await UnitOfWork.Maintenance.GetAsync(x => x.Id == maintenanceId);
            if (maintenance != null)
            {
                return new DataResult<MaintenanceDto>(ResultStatus.Success, new MaintenanceDto
                {
                    Maintenance = maintenance,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MaintenanceDto>(ResultStatus.Error, "Böyle bir bakım bulunamadı.", null);
        }

        public async Task<IResult> Update(MaintenanceUpdateDto maintenanceUpdateDto)
        {
            var maintenance = Mapper.Map<Maintenance>(maintenanceUpdateDto);
            await UnitOfWork.Maintenance.UpdateAsync(maintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckNameExist(string name)
        {
            return await UnitOfWork.Maintenance.AnyAsync(x => x.Name == name);
        }
    }
}
