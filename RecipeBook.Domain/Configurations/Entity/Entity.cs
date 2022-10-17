using RecipeBook.Core.Configurations.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Configurations.Entity
{
    public class Entity : IEntity
    {
        public int IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
