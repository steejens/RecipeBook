using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Ingredients
{
    public class Ingredient : Entity
    {
        [Key]
        public int IngredientId { get; set; }
        public string Title { get; set; }

        public float KcalPer100g { get; set; }
    }
}
