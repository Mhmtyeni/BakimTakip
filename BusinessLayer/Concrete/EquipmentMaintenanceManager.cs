using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentMaintenanceDtos;
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
    public class EquipmentMaintenanceManager : ManagerBase, IEquipmentMaintenanceService
    {
        public EquipmentMaintenanceManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(EquipmentMaintenanceAddDto equipmentMaintenanceAddDto)
        {
            var equipmentMaintenance = Mapper.Map<EquipmentMaintenance>(equipmentMaintenanceAddDto);
            await UnitOfWork.EquipmentMaintenance.AddAsync(equipmentMaintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int equipmentMaintenanceId)
        {
            var result = await UnitOfWork.EquipmentMaintenance.AnyAsync(a => a.Id == equipmentMaintenanceId);
            if (result)
            {
                var equipmentMaintenance = await UnitOfWork.EquipmentMaintenance.GetAsync(a => a.Id == equipmentMaintenanceId);
                equipmentMaintenance.IsActive = false;
                equipmentMaintenance.IsDeleted = true;
                await UnitOfWork.EquipmentMaintenance.UpdateAsync(equipmentMaintenance);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Ekipman bulunamadı.");
        }

        public async Task<IDataResult<EquipmentMaintenanceListDto>> GetAll()
        {
            IQueryable<EquipmentMaintenance> query = UnitOfWork.EquipmentMaintenance.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.ProjectEquipment).ThenInclude(x => x.Equipment)
                .Include(x => x.ProjectEquipment).ThenInclude(x => x.Project).OrderByDescending(x=>x.ModifiedDate);
            var equipmentMaintenance = await query.ToListAsync();
            if (equipmentMaintenance != null)
            {
                return new DataResult<EquipmentMaintenanceListDto>(ResultStatus.Success, new EquipmentMaintenanceListDto
                {
                    EquipmentMaintenances = equipmentMaintenance,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceListDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentMaintenanceDto>> GetById(int equipmentMaintenanceId)
        {
            var equipmentMaintenance = await UnitOfWork.EquipmentMaintenance.GetAsync(x => x.Id == equipmentMaintenanceId);
            if (equipmentMaintenance != null)
            {
                return new DataResult<EquipmentMaintenanceDto>(ResultStatus.Success, new EquipmentMaintenanceDto
                {
                    EquipmentMaintenance = equipmentMaintenance,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentMaintenanceListDto>> GetByProjectEquipmentId(int projectEquipmentId)
        {
            IQueryable<EquipmentMaintenance> query = UnitOfWork.EquipmentMaintenance.GetAsQueryable();
            query = query.Where(x => x.ProjectEquipmentId == projectEquipmentId && x.IsActive == true && x.IsDeleted == false);
            var equipmentMaintenance = await query.ToListAsync();
            if (equipmentMaintenance != null)
            {
                return new DataResult<EquipmentMaintenanceListDto>(ResultStatus.Success, new EquipmentMaintenanceListDto
                {
                    EquipmentMaintenances = equipmentMaintenance,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceListDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IResult> Update(EquipmentMaintenanceUpdateDto equipmentMaintenanceUpdateDto)
        {
            var equipmentMaintenance = Mapper.Map<EquipmentMaintenance>(equipmentMaintenanceUpdateDto);
            await UnitOfWork.EquipmentMaintenance.UpdateAsync(equipmentMaintenance);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckProjectEquipmentExist(int projectEquipmentId)
        {
            return await UnitOfWork.EquipmentMaintenance.AnyAsync(x => x.ProjectEquipmentId == projectEquipmentId);
        }
    }
}
