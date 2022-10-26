using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.AboutUs;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Domain.Entities.Ingredients;

namespace RecipeBook.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<CookingInstruction> CookingInstructions { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<Food> Food { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<FoodIngredient> FoodIngredients { get; set; }

        public DbSet<FoodType> FoodTypes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }


        public DbSet<IngredientMeasurement> IngredientMeasurements { get; set; }

        public DbSet<IngredientUnit> IngredientUnits { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }


    }
}
