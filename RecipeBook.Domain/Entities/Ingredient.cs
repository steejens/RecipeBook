
using RecipeBook.Domain.Configurations.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Entities
{
    public class Ingredient : Entity
    {
        [Key]
        public int IngredientId { get; set; }
        public string Title { get; set; }

        public float KcalPer100g { get; set; }
    }
}
