using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class MigSecondCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckOrDenied",
                table: "RobotToBeMaintainedUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CheckOrDenied",
                table: "EquipmentMaintenanceUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckOrDenied",
                table: "RobotToBeMaintainedUser");

            migrationBuilder.DropColumn(
                name: "CheckOrDenied",
                table: "EquipmentMaintenanceUser");
        }
    }
}
