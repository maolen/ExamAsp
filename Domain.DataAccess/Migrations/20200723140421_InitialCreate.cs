using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iin = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    FirstProfile = table.Column<int>(nullable: false),
                    SecondProfile = table.Column<int>(nullable: false),
                    College = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
