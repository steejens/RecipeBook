using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.Food
{
    public class FoodType : Entity
    {
        [Key]
        public int TypeId { get; set; }
        public string Title { get; set; }
    }
}
