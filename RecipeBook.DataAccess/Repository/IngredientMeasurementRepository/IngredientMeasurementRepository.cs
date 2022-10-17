using RecipeBook.Data;
using RecipeBook.Domain.Entities;

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
