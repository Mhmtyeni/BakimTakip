using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEquipmentMaintenanceUserService
    {
        public Task<IResult> Add(EquipmentMaintenanceUserAddDto equipmentMaintenanceUserAddDto);
        public Task<IResult> Update(EquipmentMaintenanceUserUpdateDto equipmentMaintenanceUserUpdateDto);
        public Task<IResult> DeleteById(int equipmentMaintenanceUserId);
        public Task<IDataResult<EquipmentMaintenanceUserListDto>> GetAll();
        public Task<IDataResult<EquipmentMaintenanceUserDto>> GetById(int equipmentMaintenanceUserId);
        public Task<IDataResult<EquipmentMaintenanceUserListDto>> GetByProjectEquipmentId(int projectEquipmentId);
        public Task<bool> CheckProjectEquipmentExist(int projectEquipmentId);
    }
}
