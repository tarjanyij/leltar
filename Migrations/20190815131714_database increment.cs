using Microsoft.EntityFrameworkCore.Migrations;

namespace leltar.Migrations
{
    public partial class databaseincrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Megnevezes2",
                table: "InventoryDatas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Megnevezes2",
                table: "InventoryDatas");
        }
    }
}
