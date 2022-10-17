
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeBook.Domain.Entities
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
