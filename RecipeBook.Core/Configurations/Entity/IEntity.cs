using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Core.Configurations.Entity
{
    public interface IEntity
    {
        int IsActive { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
