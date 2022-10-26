using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Ingredients
{
    public class IngredientUnit : Entity
    {
        [Key]
        public int UnitId { get; set; }
        public string Title { get; set; }

    }
}
