using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webprojtest3.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_Type",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    membership_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    membership_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    l_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    login_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "CoursePaper",
                columns: table => new
                {
                    CoursePaperID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePaper", x => x.CoursePaperID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    l_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergency_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    login_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "CoursePaper");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropColumn(
                name: "user_Type",
                table: "Students");
        }
    }
}
