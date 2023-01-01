using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompleteMaintenanceEquipmentService
    {

        public Task<IResult> Add(CompleteMaintenanceEquipmentAddDto completeMaintenanceEquipmentAddDto);
        public Task<IResult> Update(CompleteMaintenanceEquipmentUpdateDto completeMaintenanceEquipmentUpdateDto);
        public Task<IResult> DeleteById(int completeMaintenanceEquipmentId);
        public Task<IDataResult<CompleteMaintenanceEquipmentDto>> GetById(int completeMaintenanceEquipmentId);
        public Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetAll();
        public Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetAllMounth();
        public Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetByProjectEquipmentId(int projectEquipmentId);
    }
}
