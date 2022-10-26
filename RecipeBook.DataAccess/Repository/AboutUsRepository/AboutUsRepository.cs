using RecipeBook.Data;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.AboutUs;

namespace RecipeBook.DataAccess.Repository.AboutUsRepository
{
    public class AboutUsRepository : Repository<AboutUs>, IAboutUsRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public AboutUsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
