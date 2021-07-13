using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Identity = table.Column<string>(type: "nvarchar(9)", nullable: true),
                    Dateborn = table.Column<DateTime>(type: "date", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    HMO = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    NumOfChildren = table.Column<int>(type: "int ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    identity = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Dateborn = table.Column<DateTime>(type: "date", nullable: false),
                    tzUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Child_User_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_UserEntityId",
                table: "Child",
                column: "UserEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
