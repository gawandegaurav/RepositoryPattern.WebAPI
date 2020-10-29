using System.Linq;

namespace Domain.Interfaces
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        public IQueryable<Developer> GetTopDevelopers(int count);
    }
}