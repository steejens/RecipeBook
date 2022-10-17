
using RecipeBook.Domain.Configurations.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Entities
{
    public class IngredientUnit : Entity
    {
        [Key]
        public int UnitId { get; set; }
        public string Title { get; set; }

    }
}
