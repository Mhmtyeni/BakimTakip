using EntityLayer.Dtos.MaintenanceDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMaintenanceService
    {
        public Task<IResult> Add(MaintenanceAddDto maintenanceAddDto);
        public Task<IResult> Update(MaintenanceUpdateDto maintenanceUpdateDto);
        public Task<IResult> DeleteById(int maintenanceId);
        public Task<IDataResult<MaintenanceListDto>> GetAll();
        public Task<IDataResult<MaintenanceDto>> GetById(int maintenanceId);
        public Task<bool> CheckNameExist(string name);
    }
}
