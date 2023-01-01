using EntityLayer.Dtos.EquipmentMaintenanceDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEquipmentMaintenanceService
    {
        public Task<IResult> Add(EquipmentMaintenanceAddDto equipmentMaintenanceAddDto);
        public Task<IResult> Update(EquipmentMaintenanceUpdateDto equipmentMaintenanceUpdateDto);
        public Task<IResult> DeleteById(int equipmentMaintenanceId);
        public Task<IDataResult<EquipmentMaintenanceListDto>> GetAll();
        public Task<IDataResult<EquipmentMaintenanceDto>> GetById(int equipmentMaintenanceId);
        public Task<IDataResult<EquipmentMaintenanceListDto>> GetByProjectEquipmentId(int projectEquipmentId);
        public Task<bool> CheckProjectEquipmentExist(int projectEquipmentId);

    }
}
