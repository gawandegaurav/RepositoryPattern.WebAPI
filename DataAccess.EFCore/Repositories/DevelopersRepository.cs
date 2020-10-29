using Domain;
using Domain.Interfaces;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class DevelopersRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        private readonly ApplicationContext _context;

        public DevelopersRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _context = applicationContext;
        }

        public IQueryable<Developer> GetTopDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(x => x.Followers).Take(count);
        }
    }
}