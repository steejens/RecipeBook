using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Data.Migrations
{
    public partial class somechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CountCalories",
                table: "FoodIngredients",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeepFried",
                table: "FoodIngredients",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CookingTime",
                table: "Food",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreparationTime",
                table: "Food",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServingFor",
                table: "Food",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountCalories",
                table: "FoodIngredients");

            migrationBuilder.DropColumn(
                name: "IsDeepFried",
                table: "FoodIngredients");

            migrationBuilder.DropColumn(
                name: "CookingTime",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "PreparationTime",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "ServingFor",
                table: "Food");
        }
    }
}
