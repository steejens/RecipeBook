using RecipeBook.Data;
using RecipeBook.Domain.Entities;

namespace RecipeBook.DataAccess.Repository.FoodIngredientRepository
{
    public class FoodIngredientRepository : Repository<FoodIngredient>, IFoodIngredientRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public FoodIngredientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
