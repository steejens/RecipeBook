﻿
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeBook.Domain.Entities
{
    public class FoodIngredient : Entity
    {
        [Key]
        public int FoodIngId { get; set; }

        [ForeignKey("Food")]
        public int FoodRefId { get; set; }
        public Food Food { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientRefId { get; set; }
        public Ingredient Ingredient { get; set; }

        public float UnitCount { get; set; }

        [ForeignKey("IngredientUnit")]
        public int UnitRefId { get; set; }
        public IngredientUnit IngredientUnit { get; set; }
        public bool? IsDeepFried { get; set; }
        public bool? CountCalories { get; set; }

    }
}
