using Microsoft.EntityFrameworkCore.Migrations;

namespace webprojtest3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    f__Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    l_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
