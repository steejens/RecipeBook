using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Food
{
    public class DifficultyLevel : Entity
    {
        [Key]
        public int LevelId { get; set; }
        public int LevelValue { get; set; }
    }
}
