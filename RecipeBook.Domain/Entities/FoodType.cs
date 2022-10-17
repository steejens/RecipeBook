
using RecipeBook.Domain.Configurations.Entity;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
    public class FoodType : Entity
    {
        [Key]
        public int TypeId { get; set; }
        public string Title { get; set; }
    }
}
