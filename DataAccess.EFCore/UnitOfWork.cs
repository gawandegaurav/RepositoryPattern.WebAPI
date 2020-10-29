using DataAccess.EFCore.Repositories;
using Domain.Interfaces;
using System;

namespace DataAccess.EFCore
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext applicationContext)
        {
            _context = applicationContext;
            DeveloperRepository = new DevelopersRepository(applicationContext);
            ProjectRepository = new ProjectRepository(applicationContext);
        }

        public IDeveloperRepository DeveloperRepository { get; }

        public IProjectRepository ProjectRepository { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool shouldDispose)
        {
            if (shouldDispose)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}