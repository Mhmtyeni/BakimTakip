using EntityLayer.Dtos.RobotMaintenanceDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRobotMaintenanceService
    {
        public Task<IResult> Add(RobotMaintenanceAddDto robotMaintenanceAddDto);
        public Task<IResult> Update(RobotMaintenanceUpdateDto robotMaintenanceUpdateDto);
        public Task<IResult> DeleteById(int robotMaintenanceId);
        public Task<IResult> DeleteByMaintenanceId(int maintenanceId);
        public Task<IDataResult<RobotMaintenanceListDto>> GetAll();
        public Task<IDataResult<RobotMaintenanceDto>> GetById(int robotMaintenanceId);
        public Task<IDataResult<RobotMaintenanceListDto>> GetRobotCategoryId(int robotCategoryId);
        public Task<IDataResult<RobotMaintenanceListDto>> GetRobotId(int robotId);
        public Task<IDataResult<RobotMaintenanceListDto>> GetAllMaintenance(int robotId);
        public Task<bool> CheckRobotMaintenanceExist(int maintenanceId,int robotId);
    }
}
