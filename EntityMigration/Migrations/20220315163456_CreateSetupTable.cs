using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityMigration.Migrations
{
    public partial class CreateSetupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Load = table.Column<int>(nullable: false),
                    HomeProductTake = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Setups",
                columns: new[] { "Id", "HomeProductTake", "Load" },
                values: new object[] { 1, 8, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setups");
        }
    }
}
