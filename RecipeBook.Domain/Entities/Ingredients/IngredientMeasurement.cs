using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Ingredients
{
    public class IngredientMeasurement : Entity
    {
        [Key]
        public int IngMeaId { get; set; }

        [ForeignKey("IngredientUnit")]
        public int UnitRefId { get; set; }
        public IngredientUnit IngredientUnit { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientRefId { get; set; }
        public Ingredient Ingredient { get; set; }
        public float GramPerUnit { get; set; }
    }
}
