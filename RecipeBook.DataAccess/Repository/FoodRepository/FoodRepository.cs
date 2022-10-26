using RecipeBook.Data;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;

namespace RecipeBook.DataAccess.Repository.FoodRepository
{
    public class FoodRepository : Repository<Food>, IFoodRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public FoodRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
