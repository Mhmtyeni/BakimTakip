using DataAccsessLayer.Abstract;
using DataAccsessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private EfCompleteMaintenanceEquipmentDal _completeMaintenanceEquipmentDal;
        private EfCompleteMaintenanceRobotDal _completeMaintenanceRobotDal;
        private EfEquipmentCategoryDal _equipmentCategoryDal;
        private EfEquipmentDal _equipmentDal;
        private EfEquipmentMaintenanceDal _equipmentMaintenanceDal;
        private EfEquipmentMaintenanceUserDal _equipmentMaintenanceUserDal;
        private EfFactoryDal _factoryDal;
        private EfFactoryDepartmentDal _factoryDepartmentDal;
        private EfProjectDal _projecDal;
        private EfProjectEquipmentDal _projectEquipmentDal;
        private EfProjectResponsibleDal _projectResponsibleDal;
        private EfProjectRobotDal _projectRobotDal;
        private EfRobotCategoryDal _robotCategoryDal;
        private EfRobotDal _robotDal;
        private EfRobotMaintenanceDal _robotMaintenanceDal;
        private EfRobotToBeMaintainedDal _robotToBeMaintainedDal;
        private EfRobotToBeMaintainedUserDal _robotToBeMaintainedUserDal;
        private EfAppUserDal _appUserDal;
        private EfMaintenanceDal _maintenanceDal;
        private EfFaultReportDal _faultReportDal;
        private EfProjectReportDal _projectReportDal;

        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public ICompleteMaintenanceEquipmentDal CompleteMaintenanceEquipment => _completeMaintenanceEquipmentDal ?? new EfCompleteMaintenanceEquipmentDal(_context);

        public ICompleteMaintenanceRobotDal CompleteMaintenanceRobot => _completeMaintenanceRobotDal ?? new EfCompleteMaintenanceRobotDal(_context);

        public IEquipmentCategoryDal EquipmentCategory => _equipmentCategoryDal ?? new EfEquipmentCategoryDal(_context);

        public IEquipmentDal Equipment => _equipmentDal ?? new EfEquipmentDal(_context);

        public IEquipmentMaintenanceDal EquipmentMaintenance => _equipmentMaintenanceDal ?? new EfEquipmentMaintenanceDal(_context);

        public IEquipmentMaintenanceUserDal EquipmentMaintenanceUser => _equipmentMaintenanceUserDal ?? new EfEquipmentMaintenanceUserDal(_context);

        public IFactoryDal Factory => _factoryDal ?? new EfFactoryDal(_context);

        public IFactoryDepartmentDal FactoryDepartment => _factoryDepartmentDal ?? new EfFactoryDepartmentDal(_context);

        public IProjectDal Project => _projecDal ?? new EfProjectDal(_context);

        public IProjectEquipmentDal ProjectEquipment => _projectEquipmentDal ?? new EfProjectEquipmentDal(_context);

        public IProjectResponsibleDal ProjectResponsible => _projectResponsibleDal ?? new EfProjectResponsibleDal(_context);

        public IProjectRobotDal ProjectRobot => _projectRobotDal ?? new EfProjectRobotDal(_context);

        public IRobotCategoryDal RobotCategory => _robotCategoryDal ?? new EfRobotCategoryDal(_context);

        public IRobotDal Robot => _robotDal ?? new EfRobotDal(_context);

        public IRobotMaintenanceDal RobotMaintenance => _robotMaintenanceDal ?? new EfRobotMaintenanceDal(_context);

        public IMaintenanceDal Maintenance => _maintenanceDal ?? new EfMaintenanceDal(_context);

        public IRobotToBeMaintainedDal RobotToBeMaintained => _robotToBeMaintainedDal ?? new EfRobotToBeMaintainedDal(_context);

        public IRobotToBeMaintainedUserDal RobotToBeMaintainedUser => _robotToBeMaintainedUserDal ?? new EfRobotToBeMaintainedUserDal(_context);

        public IAppUserDal AppUser => _appUserDal ?? new EfAppUserDal(_context);
        public IFaultReportDal FaultReport => _faultReportDal ?? new EfFaultReportDal(_context);
        public IProjectReportDal ProjectReport => _projectReportDal ?? new EfProjectReportDal(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
