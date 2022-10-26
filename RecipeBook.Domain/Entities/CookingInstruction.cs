
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeBook.Domain.Entities
{
    public class CookingInstruction : Entity
    {
        [Key]
        public int InstId { get; set; }

        [ForeignKey("Food")]
        public int FoodRefId { get; set; }
        public Food.Food Food { get; set; }

        public  string InstructionStepText { get; set; }
        public int? StepOrder { get; set; }
    }
}
