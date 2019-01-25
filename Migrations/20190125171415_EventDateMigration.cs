using Microsoft.EntityFrameworkCore.Migrations;

namespace Activity.Migrations
{
    public partial class EventDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoodinatorID",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CoodinatorID",
                table: "Events",
                column: "CoodinatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_CoodinatorID",
                table: "Events",
                column: "CoodinatorID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_CoodinatorID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CoodinatorID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CoodinatorID",
                table: "Events");
        }
    }
}
