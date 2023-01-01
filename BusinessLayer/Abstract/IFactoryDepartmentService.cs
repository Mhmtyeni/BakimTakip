using EntityLayer.Dtos.FactoryDepartmentDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFactoryDepartmentService
    {
        public Task<IResult> Add(FactoryDepartmentAddDto factoryDepartmentAddDto);
        public Task<IResult> Update(FactoryDepartmentUpdateDto factoryDepartmentUpdateDto);
        public Task<IResult> DeleteById(int factoryDepartmentId);
        public Task<IDataResult<FactoryDepartmentListDto>> GetAll();
        public Task<IDataResult<FactoryDepartmentDto>> GetById(int factoryDepartmentId);
        public Task<IDataResult<FactoryDepartmentListDto>> GetByFactoryId(int factoryId);
    }
}
