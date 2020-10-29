using Domain;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}