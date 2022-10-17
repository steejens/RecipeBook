using RecipeBook.Data;
using RecipeBook.Domain.Entities;

namespace RecipeBook.DataAccess.Repository.CookingInstructionsRepository
{
    public class CookingInstructionsRepository : Repository<CookingInstruction>, ICookingInstructionsRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public CookingInstructionsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
