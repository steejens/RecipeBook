using RecipeBook.Data;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Ingredients;

namespace RecipeBook.DataAccess.Repository.IngredientMeasurementRepository
{
    public class IngredientMeasurementRepository : Repository<IngredientMeasurement>, IIngredientMeasurementRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public IngredientMeasurementRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
