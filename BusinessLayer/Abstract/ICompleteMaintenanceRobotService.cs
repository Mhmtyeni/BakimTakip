using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompleteMaintenanceRobotService
    {
        public Task<IResult> Add(CompleteMaintenanceRobotAddDto completeMaintenanceRobotAddDto);
        public Task<IResult> Update(CompleteMaintenanceRobotUpdateDto completeMaintenanceRobotUpdateDto);
        public Task<IResult> DeleteById(int completeMaintenanceRobotId);
        public Task<IDataResult<CompleteMaintenanceRobotListDto>> GetAll();
        public Task<IDataResult<CompleteMaintenanceRobotListDto>> GetAllMounth();
        public Task<IDataResult<CompleteMaintenanceRobotDto>> GetById(int completeMaintenanceRobotId);
        public Task<IDataResult<CompleteMaintenanceRobotListDto>> GetByProjectRobotId(int projectRobotId);
    }
}
