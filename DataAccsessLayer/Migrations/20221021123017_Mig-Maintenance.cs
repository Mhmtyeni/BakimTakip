using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class MigMaintenance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaintenanceComment",
                table: "RobotMaintenances");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RobotMaintenances");

            migrationBuilder.RenameColumn(
                name: "Periyod",
                table: "RobotMaintenances",
                newName: "MaintenanceId");

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period = table.Column<int>(type: "int", nullable: false),
                    MaintenanceComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Maintenance", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RobotMaintenances_MaintenanceId",
                table: "RobotMaintenances",
                column: "MaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RobotMaintenances_Maintenance_MaintenanceId",
                table: "RobotMaintenances",
                column: "MaintenanceId",
                principalTable: "Maintenance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RobotMaintenances_Maintenance_MaintenanceId",
                table: "RobotMaintenances");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropIndex(
                name: "IX_RobotMaintenances_MaintenanceId",
                table: "RobotMaintenances");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "RobotMaintenances",
                newName: "Periyod");

            migrationBuilder.AddColumn<string>(
                name: "MaintenanceComment",
                table: "RobotMaintenances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RobotMaintenances",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
