using EntityLayer.Dtos.RobotDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRobotService
    {
        public Task<IResult> Add(RobotAddDto robotAddDto);
        public Task<IResult> Update(RobotUpdateDto robotUpdateDto);
        public Task<IResult> DeleteById(int robotId);
        public Task<IDataResult<RobotListDto>> GetAll();
        public Task<IDataResult<RobotDto>> GetById(int robotId);
        public Task<IDataResult<RobotListDto>> GetByRobotCategoryId(int robotCategoryId);
        public Task<bool> CheckNameExist(string name);
        public Task<IDataResult<RobotListDto>> SearchByKeyword(string keyword);
    }
}
