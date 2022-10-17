
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
    public class FoodCategory : Entity
    {
        [Key]
        public int CatId { get; set; }
        public string? Title { get; set; }
    }
}
