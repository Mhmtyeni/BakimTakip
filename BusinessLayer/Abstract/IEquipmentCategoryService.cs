using EntityLayer.Dtos.EquipmentCategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEquipmentCategoryService
    {
        public Task<IResult> Add(EquipmentCategoryAddDto equipmentCategoryAddDto);
        public Task<IResult> Update(EquipmentCategoryUpdateDto equipmentCategoryUpdateDto);
        public Task<IResult> DeleteById(int equipmentCategoryById);
        public Task<IDataResult<EquipmentCategoryListDto>> GetAll();
        public Task<IDataResult<EquipmentCategoryDto>> GetById(int equipmentCategoryId);
        public Task<IDataResult<EquipmentCategoryListDto>> GetBySubId(int subId);
    }
}
