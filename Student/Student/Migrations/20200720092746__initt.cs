using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Student.Migrations
{
    public partial class _initt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
   

            migrationBuilder.CreateTable(
                name: "studentss",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    Nick = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentss", x => x.Id);
                });

        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "studentss");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
