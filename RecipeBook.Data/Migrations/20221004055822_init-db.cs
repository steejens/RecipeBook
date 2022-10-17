using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RecipeBook.Data.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LevelValue = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "IngredientCalories",
                columns: table => new
                {
                    IngCalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KcalPer100g = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCalories", x => x.IngCalId);
                });

            migrationBuilder.CreateTable(
                name: "IngredientUnits",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientUnits", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CoverPhoto = table.Column<string>(type: "text", nullable: false),
                    DifficultyRefId = table.Column<int>(type: "integer", nullable: false),
                    CategoryRefId = table.Column<int>(type: "integer", nullable: false),
                    TypeRefId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Food_DifficultyLevels_DifficultyRefId",
                        column: x => x.DifficultyRefId,
                        principalTable: "DifficultyLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_FoodCategories_CategoryRefId",
                        column: x => x.CategoryRefId,
                        principalTable: "FoodCategories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_FoodTypes_TypeRefId",
                        column: x => x.TypeRefId,
                        principalTable: "FoodTypes",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    IngredientCaloryId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_IngredientCalories_IngredientCaloryId",
                        column: x => x.IngredientCaloryId,
                        principalTable: "IngredientCalories",
                        principalColumn: "IngCalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CookingInstructions",
                columns: table => new
                {
                    InstId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FoodRefId = table.Column<int>(type: "integer", nullable: false),
                    InstructionStepText = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookingInstructions", x => x.InstId);
                    table.ForeignKey(
                        name: "FK_CookingInstructions_Food_FoodRefId",
                        column: x => x.FoodRefId,
                        principalTable: "Food",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodIngredients",
                columns: table => new
                {
                    FoodIngId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FoodRefId = table.Column<int>(type: "integer", nullable: false),
                    IngredientRefId = table.Column<int>(type: "integer", nullable: false),
                    UnitCount = table.Column<float>(type: "real", nullable: false),
                    UnitRefId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodIngredients", x => x.FoodIngId);
                    table.ForeignKey(
                        name: "FK_FoodIngredients_Food_FoodRefId",
                        column: x => x.FoodRefId,
                        principalTable: "Food",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodIngredients_Ingredients_IngredientRefId",
                        column: x => x.IngredientRefId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodIngredients_IngredientUnits_UnitRefId",
                        column: x => x.UnitRefId,
                        principalTable: "IngredientUnits",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientMeasurements",
                columns: table => new
                {
                    IngMeaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitRefId = table.Column<int>(type: "integer", nullable: false),
                    IngredientRefId = table.Column<int>(type: "integer", nullable: false),
                    GramPerUnit = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientMeasurements", x => x.IngMeaId);
                    table.ForeignKey(
                        name: "FK_IngredientMeasurements_Ingredients_IngredientRefId",
                        column: x => x.IngredientRefId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientMeasurements_IngredientUnits_UnitRefId",
                        column: x => x.UnitRefId,
                        principalTable: "IngredientUnits",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CookingInstructions_FoodRefId",
                table: "CookingInstructions",
                column: "FoodRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_CategoryRefId",
                table: "Food",
                column: "CategoryRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_DifficultyRefId",
                table: "Food",
                column: "DifficultyRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_TypeRefId",
                table: "Food",
                column: "TypeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodIngredients_FoodRefId",
                table: "FoodIngredients",
                column: "FoodRefId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodIngredients_IngredientRefId",
                table: "FoodIngredients",
                column: "IngredientRefId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodIngredients_UnitRefId",
                table: "FoodIngredients",
                column: "UnitRefId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientMeasurements_IngredientRefId",
                table: "IngredientMeasurements",
                column: "IngredientRefId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientMeasurements_UnitRefId",
                table: "IngredientMeasurements",
                column: "UnitRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientCaloryId",
                table: "Ingredients",
                column: "IngredientCaloryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookingInstructions");

            migrationBuilder.DropTable(
                name: "FoodIngredients");

            migrationBuilder.DropTable(
                name: "IngredientMeasurements");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "IngredientUnits");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodTypes");

            migrationBuilder.DropTable(
                name: "IngredientCalories");
        }
    }
}
