using EntityLayer.Dtos.RobotCategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRobotCategoryService
    {
        public Task<IResult> Add(RobotCategoryAddDto robotCategoryAddDto);
        public Task<IResult> Update(RobotCategoryUpdateDto robotCategoryUpdateDto);
        public Task<IResult> DeleteById(int robotCategoryId);
        public Task<IDataResult<RobotCategoryListDto>> GetAll();
        public Task<IDataResult<RobotCategoryDto>> GetById(int robotCategoryId);
    }
}
