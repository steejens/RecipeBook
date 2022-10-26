using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Configurations.Entity;

namespace RecipeBook.Domain.Entities.AboutUs
{
    public class AboutUs : Entity
    {
        [Key]
        public int Id { get; set; }
        public int HtmlContent { get; set; }
    }
}
