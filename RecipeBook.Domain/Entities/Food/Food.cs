using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Food
{
    public class Food : Entity
    {
        [Key]
        public int FoodId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverPhoto { get; set; }

        [ForeignKey("DifficultyLevel")]
        public int DifficultyRefId { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }

        [ForeignKey("FoodCategory")]
        public int CategoryRefId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        [ForeignKey("FoodType")]
        public int TypeRefId { get; set; }
        public FoodType FoodType { get; set; }
        public int? PreparationTime { get; set; }
        public int? CookingTime { get; set; }
        public int? ServingFor { get; set; }
    }
}
