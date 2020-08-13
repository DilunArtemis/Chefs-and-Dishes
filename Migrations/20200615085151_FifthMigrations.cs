using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsDishes.Migrations
{
    public partial class FifthMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chef",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dishes",
                newName: "DishName");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Dishes",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DishName",
                table: "Dishes",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Dishes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chef",
                table: "Dishes",
                nullable: false,
                defaultValue: "");
        }
    }
}
