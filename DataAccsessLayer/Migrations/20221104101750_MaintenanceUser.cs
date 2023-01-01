using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class MaintenanceUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentMaintenanceUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectEquipmentId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoneOrNotDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentMaintenanceUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentMaintenanceUser_ProjectEquipment_ProjectEquipmentId",
                        column: x => x.ProjectEquipmentId,
                        principalTable: "ProjectEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RobotToBeMaintainedUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectRobotId = table.Column<int>(type: "int", nullable: true),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RobotMaintenanceId = table.Column<int>(type: "int", nullable: false),
                    DoneOrNotDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotToBeMaintainedUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RobotToBeMaintainedUser_ProjectRobots_ProjectRobotId",
                        column: x => x.ProjectRobotId,
                        principalTable: "ProjectRobots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RobotToBeMaintainedUser_RobotMaintenances_RobotMaintenanceId",
                        column: x => x.RobotMaintenanceId,
                        principalTable: "RobotMaintenances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentMaintenanceUser_ProjectEquipmentId",
                table: "EquipmentMaintenanceUser",
                column: "ProjectEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotToBeMaintainedUser_ProjectRobotId",
                table: "RobotToBeMaintainedUser",
                column: "ProjectRobotId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotToBeMaintainedUser_RobotMaintenanceId",
                table: "RobotToBeMaintainedUser",
                column: "RobotMaintenanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentMaintenanceUser");

            migrationBuilder.DropTable(
                name: "RobotToBeMaintainedUser");
        }
    }
}
