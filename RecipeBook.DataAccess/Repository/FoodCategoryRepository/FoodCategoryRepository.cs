using RecipeBook.Data;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;

namespace RecipeBook.DataAccess.Repository.FoodCategoryRepository
{
    public class FoodCategoryRepository : Repository<FoodCategory>, IFoodCategoryRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public FoodCategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
