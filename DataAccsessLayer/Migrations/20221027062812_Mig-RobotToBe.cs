using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class MigRobotToBe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RobotToBeMaintaineds_ProjectEquipment_ProjectEquipmentId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.DropIndex(
                name: "IX_RobotToBeMaintaineds_ProjectEquipmentId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.DropColumn(
                name: "ProjectEquipmentId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.AddColumn<int>(
                name: "ProjectRobotId",
                table: "RobotToBeMaintaineds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RobotToBeMaintaineds_ProjectRobotId",
                table: "RobotToBeMaintaineds",
                column: "ProjectRobotId");

            migrationBuilder.AddForeignKey(
                name: "FK_RobotToBeMaintaineds_ProjectRobots_ProjectRobotId",
                table: "RobotToBeMaintaineds",
                column: "ProjectRobotId",
                principalTable: "ProjectRobots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RobotToBeMaintaineds_ProjectRobots_ProjectRobotId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.DropIndex(
                name: "IX_RobotToBeMaintaineds_ProjectRobotId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.DropColumn(
                name: "ProjectRobotId",
                table: "RobotToBeMaintaineds");

            migrationBuilder.AddColumn<int>(
                name: "ProjectEquipmentId",
                table: "RobotToBeMaintaineds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RobotToBeMaintaineds_ProjectEquipmentId",
                table: "RobotToBeMaintaineds",
                column: "ProjectEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_RobotToBeMaintaineds_ProjectEquipment_ProjectEquipmentId",
                table: "RobotToBeMaintaineds",
                column: "ProjectEquipmentId",
                principalTable: "ProjectEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
