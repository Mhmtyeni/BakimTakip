using EntityLayer.Dtos.RobotToBeMaintainedDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRobotToBeMaintainedService
    {
        public Task<IResult> Add(RobotToBeMaintainedAddDto robotToBeMaintainedAddDto);
        public Task<IResult> Update(RobotToBeMaintainedUpdateDto robotToBeMaintainedUpdateDto);
        public Task<IResult> DeleteById(int robotToBeMaintainedId);
        public Task<IDataResult<RobotToBeMaintainedListDto>> GetAll();
        public Task<IDataResult<RobotToBeMaintainedDto>> GetById(int robotToBeMaintainedId);
        public Task<IDataResult<RobotToBeMaintainedListDto>> GetByProjectRobotId(int projectRobotId);
        public Task<IDataResult<RobotToBeMaintainedListDto>> GetByRobotMaintenanceId(int robotMaintenanceId);
        public Task<bool> CheckProjectRobotExist(int projectRobotId);
    }
}
