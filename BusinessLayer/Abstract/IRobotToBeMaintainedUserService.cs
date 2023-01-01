using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRobotToBeMaintainedUserService
    {
        public Task<IResult> Add(RobotToBeMaintainedUserAddDto robotToBeMaintainedUserAddDto);
        public Task<IResult> Update(RobotToBeMaintainedUserUpdateDto robotToBeMaintainedUserUpdateDto);
        public Task<IResult> DeleteById(int robotToBeMaintainedUserId);
        public Task<IDataResult<RobotToBeMaintainedUserListDto>> GetAll();
        public Task<IDataResult<RobotToBeMaintainedUserDto>> GetById(int robotToBeMaintainedUserId);
        public Task<IDataResult<RobotToBeMaintainedUserListDto>> GetByProjectRobotId(int projectRobotId);
        public Task<IDataResult<RobotToBeMaintainedUserListDto>> GetByRobotMaintenanceId(int robotMaintenanceId);
        public Task<bool> CheckProjectRobotExist(int projectRobotId,int robotMainteananceId);
    }
}
