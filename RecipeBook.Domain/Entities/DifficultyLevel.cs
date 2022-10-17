
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
    public class DifficultyLevel : Entity
    {
        [Key]
        public int LevelId { get; set; }
        public int LevelValue { get; set; }
    }
}
