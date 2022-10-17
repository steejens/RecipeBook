using RecipeBook.Data;
using RecipeBook.Domain.Entities;

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
