using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Food
{
    public class FoodCategory : Entity
    {
        [Key]
        public int CatId { get; set; }
        public string? Title { get; set; }
    }
}
