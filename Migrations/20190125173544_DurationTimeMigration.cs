using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Activity.Migrations
{
    public partial class DurationTimeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_CoodinatorID",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "CoodinatorID",
                table: "Events",
                newName: "CoordinatorID");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CoodinatorID",
                table: "Events",
                newName: "IX_Events_CoordinatorID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_CoordinatorID",
                table: "Events",
                column: "CoordinatorID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_CoordinatorID",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "CoordinatorID",
                table: "Events",
                newName: "CoodinatorID");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CoordinatorID",
                table: "Events",
                newName: "IX_Events_CoodinatorID");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_CoodinatorID",
                table: "Events",
                column: "CoodinatorID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
