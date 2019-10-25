using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CancelDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surename = table.Column<string>(nullable: true),
                    BirtDay = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CancelDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Pasword = table.Column<string>(nullable: true),
                    Personnelid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Personnels_Personnelid",
                        column: x => x.Personnelid,
                        principalTable: "Personnels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Personnelid",
                table: "Users",
                column: "Personnelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Personnels");
        }
    }
}
