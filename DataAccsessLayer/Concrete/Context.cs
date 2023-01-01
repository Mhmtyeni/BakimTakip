using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=10.108.206.13; Database=RobotMaintenanceDB; integrated security=false; User Id=sa; password=123456");
            optionsBuilder.UseSqlServer("server=10.3.0.42; Database=RobotMaintenanceDB; integrated security=false; User Id=sa; password=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<CompleteMaintenanceEquipment> CompleteMaintenanceEquipment { get; set; }
        public DbSet<CompleteMaintenanceRobot> CompleteMaintenanceRobots { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentCategory> EquipmentCategories { get; set; }
        public DbSet<EquipmentMaintenance> EquipmentMaintenances { get; set; }
        public DbSet<EquipmentMaintenanceUser> EquipmentMaintenanceUser { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryDepartment> FactoryDepartments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEquipment> ProjectEquipment { get; set; }
        public DbSet<ProjectResponsible> ProjectResponsibles { get; set; }
        public DbSet<ProjectRobot> ProjectRobots { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public DbSet<RobotCategory> RobotCategories { get; set; }
        public DbSet<RobotMaintenance> RobotMaintenances { get; set; }
        public DbSet<RobotToBeMaintained> RobotToBeMaintaineds { get; set; }
        public DbSet<RobotToBeMaintainedUser> RobotToBeMaintainedUser { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<FaultReport> FaultReports { get; set; }
        public DbSet<ProjectReport> ProjectReports { get; set; }

    }
}
