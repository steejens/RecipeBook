using RecipeBook.Data;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;

namespace RecipeBook.DataAccess.Repository.FoodTypeRepository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public FoodTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
