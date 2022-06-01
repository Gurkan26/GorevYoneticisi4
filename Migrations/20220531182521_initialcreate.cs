using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GorevYoneticisi4.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorevler",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    start = table.Column<DateTime>(nullable: false),
                    end = table.Column<DateTime>(nullable: false),
                    color = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    textColor = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevler", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorevler");
        }
    }
}
