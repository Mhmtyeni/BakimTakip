using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<Context>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICompleteMaintenanceEquipmentService, CompleteMaintenanceEquipmentManager>();
            serviceCollection.AddScoped<ICompleteMaintenanceRobotService, CompleteMaintenanceRobotManager>();
            serviceCollection.AddScoped<IEquipmentCategoryService, EquipmentCategoryManager>();
            serviceCollection.AddScoped<IEquipmentMaintenanceService, EquipmentMaintenanceManager>();
            serviceCollection.AddScoped<IEquipmentMaintenanceUserService, EquipmentMaintenanceUserManager>();
            serviceCollection.AddScoped<IEquipmentService, EquipmentManager>();
            serviceCollection.AddScoped<IFactoryDepartmentService, FactoryDepartmentManager>();
            serviceCollection.AddScoped<IFactoryService, FactoryManager>();
            serviceCollection.AddScoped<IProjectEquipmentService, ProjectEquipmentManager>();
            serviceCollection.AddScoped<IProjectResponsibleService, ProjectResponsibleManager>();
            serviceCollection.AddScoped<IProjectRobotService, ProjectRobotManager>();
            serviceCollection.AddScoped<IProjectService, ProjectManager>();
            serviceCollection.AddScoped<IRobotCategoryService, RobotCategoryManager>();
            serviceCollection.AddScoped<IRobotMaintenanceService, RobotMaintenanceManager>();
            serviceCollection.AddScoped<IMaintenanceService, MaintenanceManager>();
            serviceCollection.AddScoped<IRobotService, RobotManager>();
            serviceCollection.AddScoped<IRobotToBeMaintainedService, RobotToBeMaintainedManager>();
            serviceCollection.AddScoped<IRobotToBeMaintainedUserService, RobotToBeMaintainedUserManager>();
            serviceCollection.AddScoped<IAppUserService, AppUserManager>();
            serviceCollection.AddScoped<IFaultReportService, FaultReportManager>();
            serviceCollection.AddScoped<IProjectReportService, ProjectReportManager>();
            return serviceCollection;
        }
    }
}
