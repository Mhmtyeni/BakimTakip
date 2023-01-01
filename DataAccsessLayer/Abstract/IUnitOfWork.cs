using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICompleteMaintenanceEquipmentDal CompleteMaintenanceEquipment { get; }
        ICompleteMaintenanceRobotDal CompleteMaintenanceRobot { get; }
        IEquipmentCategoryDal EquipmentCategory { get; }
        IEquipmentDal Equipment { get; }
        IEquipmentMaintenanceDal EquipmentMaintenance { get; }
        IEquipmentMaintenanceUserDal EquipmentMaintenanceUser { get; }
        IFactoryDal Factory { get; }
        IFactoryDepartmentDal FactoryDepartment { get; }
        IProjectDal Project { get; }
        IProjectEquipmentDal ProjectEquipment { get; }
        IProjectResponsibleDal ProjectResponsible { get; }
        IProjectRobotDal ProjectRobot { get; }
        IRobotCategoryDal RobotCategory { get; }
        IRobotDal Robot { get; }
        IRobotMaintenanceDal RobotMaintenance { get; }
        IRobotToBeMaintainedDal RobotToBeMaintained { get; }
        IRobotToBeMaintainedUserDal RobotToBeMaintainedUser { get; }
        IAppUserDal AppUser { get; }
        IMaintenanceDal Maintenance { get; }
        IFaultReportDal FaultReport { get; }
        IProjectReportDal ProjectReport { get; }

        Task<int> SaveAsync();
    }
}
