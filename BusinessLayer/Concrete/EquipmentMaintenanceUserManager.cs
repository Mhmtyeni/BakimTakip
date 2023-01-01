using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;
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
    public class EquipmentMaintenanceUserManager : ManagerBase, IEquipmentMaintenanceUserService
    {
        public EquipmentMaintenanceUserManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(EquipmentMaintenanceUserAddDto equipmentMaintenanceUserAddDto)
        {
            var equipmentMaintenanceUser = Mapper.Map<EquipmentMaintenanceUser>(equipmentMaintenanceUserAddDto);
            await UnitOfWork.EquipmentMaintenanceUser.AddAsync(equipmentMaintenanceUser);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<bool> CheckProjectEquipmentExist(int projectEquipmentId)
        {
            return await UnitOfWork.EquipmentMaintenanceUser.AnyAsync(x => x.ProjectEquipmentId == projectEquipmentId);
        }

        public async Task<IResult> DeleteById(int equipmentMaintenanceUserId)
        {
            var result = await UnitOfWork.EquipmentMaintenanceUser.AnyAsync(a => a.Id == equipmentMaintenanceUserId);
            if (result)
            {
                var equipmentMaintenanceUser = await UnitOfWork.EquipmentMaintenanceUser.GetAsync(a => a.Id == equipmentMaintenanceUserId);
                equipmentMaintenanceUser.IsActive = false;
                equipmentMaintenanceUser.IsDeleted = true;
                await UnitOfWork.EquipmentMaintenanceUser.UpdateAsync(equipmentMaintenanceUser);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Ekipman bulunamadı.");
        }

        public async Task<IDataResult<EquipmentMaintenanceUserListDto>> GetAll()
        {
            IQueryable<EquipmentMaintenanceUser> query = UnitOfWork.EquipmentMaintenanceUser.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.ProjectEquipment).ThenInclude(x => x.Equipment)
                .Include(x => x.ProjectEquipment).ThenInclude(x => x.Project).OrderByDescending(x => x.ModifiedDate);
            var equipmentMaintenanceUser = await query.ToListAsync();
            if (equipmentMaintenanceUser != null)
            {
                return new DataResult<EquipmentMaintenanceUserListDto>(ResultStatus.Success, new EquipmentMaintenanceUserListDto
                {
                    EquipmentMaintenanceUsers = equipmentMaintenanceUser,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceUserListDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentMaintenanceUserDto>> GetById(int equipmentMaintenanceUserId)
        {
            var equipmentMaintenanceUser = await UnitOfWork.EquipmentMaintenanceUser.GetAsync(x => x.Id == equipmentMaintenanceUserId, x => x.ProjectEquipment.Project,x=>x.ProjectEquipment.Equipment);
            if (equipmentMaintenanceUser != null)
            {
                return new DataResult<EquipmentMaintenanceUserDto>(ResultStatus.Success, new EquipmentMaintenanceUserDto
                {
                    EquipmentMaintenanceUser = equipmentMaintenanceUser,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceUserDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentMaintenanceUserListDto>> GetByProjectEquipmentId(int projectEquipmentId)
        {
            IQueryable<EquipmentMaintenanceUser> query = UnitOfWork.EquipmentMaintenanceUser.GetAsQueryable();
            query = query.Where(x => x.ProjectEquipmentId == projectEquipmentId && x.IsActive == true && x.IsDeleted == false);
            var equipmentMaintenanceUser = await query.ToListAsync();
            if (equipmentMaintenanceUser != null)
            {
                return new DataResult<EquipmentMaintenanceUserListDto>(ResultStatus.Success, new EquipmentMaintenanceUserListDto
                {
                    EquipmentMaintenanceUsers = equipmentMaintenanceUser,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentMaintenanceUserListDto>(ResultStatus.Error, "Ekipman bulunamadı.", null);
        }

        public async Task<IResult> Update(EquipmentMaintenanceUserUpdateDto equipmentMaintenanceUserUpdateDto)
        {
            var equipmentMaintenanceUser = Mapper.Map<EquipmentMaintenanceUser>(equipmentMaintenanceUserUpdateDto);
            await UnitOfWork.EquipmentMaintenanceUser.UpdateAsync(equipmentMaintenanceUser);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
