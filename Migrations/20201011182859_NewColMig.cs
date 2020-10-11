using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMigrationScript.Migrations
{
    public partial class NewColMig : Migration
    {
        // This migration is not implemented in the WIndocks sample customers database
        // This is your TO migration
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "new_col",
                table: "Customers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "new_col",
                table: "Customers");
        }
    }
}
