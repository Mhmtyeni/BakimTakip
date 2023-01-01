using EntityLayer.Dtos.EquipmentDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEquipmentService
    {
        public Task<IResult> Add(EquipmentAddDto equipmentAddDto);
        public Task<IResult> Update(EquipmentUpdateDto equipmentUpdateDto);
        public Task<IResult> DeleteById(int equipmentId);
        public Task<IDataResult<EquipmentListDto>> GetAll();
        public Task<IDataResult<EquipmentDto>> GetById(int equipmentId);
        public Task<IDataResult<EquipmentListDto>> GetByEquimentCategoryId(int equimentCategoryId);
        public Task<bool> CheckNameExist(string name);
        public Task<IDataResult<EquipmentListDto>> SearchByKeyword(string keyword);
    }
}
