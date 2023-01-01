using EntityLayer.Dtos.ProjectEquipmentDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectEquipmentService
    {
        public Task<IResult> Add(ProjectEquipmentAddDto projectEquipmentAddDto);
        public Task<IResult> Update(ProjectEquipmentUpdateDto projectEquipmentUpdateDto);
        public Task<IResult> DeleteById(int projectEquipmentId);
        public Task<IDataResult<ProjectEquipmentListDto>> GetAll();
        public Task<IDataResult<ProjectEquipmentListDto>> GetAllEquipment(int projectId);
        public Task<IDataResult<ProjectEquipmentDto>> GetById(int projectEquipmentId);
        public Task<IDataResult<ProjectEquipmentListDto>> GetByEquipmentId(int equipmentId);
        public Task<IDataResult<ProjectEquipmentListDto>> GetByProjectId(int equipmentId);
        public Task<IDataResult<ProjectEquipmentListDto>> GetByProjectEquipmentId(int equipmentId);
    }
}
