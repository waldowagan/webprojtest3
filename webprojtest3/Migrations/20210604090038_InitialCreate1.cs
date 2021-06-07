using Microsoft.EntityFrameworkCore.Migrations;

namespace webprojtest3.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "f__Name",
                table: "Students",
                newName: "f_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "f_Name",
                table: "Students",
                newName: "f__Name");
        }
    }
}
