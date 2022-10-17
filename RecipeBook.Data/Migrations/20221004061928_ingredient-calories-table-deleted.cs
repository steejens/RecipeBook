using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RecipeBook.Data.Migrations
{
    public partial class ingredientcaloriestabledeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_IngredientCalories_IngredientCaloryId",
                table: "Ingredients");

            migrationBuilder.DropTable(
                name: "IngredientCalories");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_IngredientCaloryId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientCaloryId",
                table: "Ingredients");

            migrationBuilder.AddColumn<float>(
                name: "KcalPer100g",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KcalPer100g",
                table: "Ingredients");

            migrationBuilder.AddColumn<int>(
                name: "IngredientCaloryId",
                table: "Ingredients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "IngredientCalories",
                columns: table => new
                {
                    IngCalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    KcalPer100g = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCalories", x => x.IngCalId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientCaloryId",
                table: "Ingredients",
                column: "IngredientCaloryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_IngredientCalories_IngredientCaloryId",
                table: "Ingredients",
                column: "IngredientCaloryId",
                principalTable: "IngredientCalories",
                principalColumn: "IngCalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
