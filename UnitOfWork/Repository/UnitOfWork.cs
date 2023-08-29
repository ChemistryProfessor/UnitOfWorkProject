using Microsoft.EntityFrameworkCore.Metadata;
using UnitOfWork.Models;
using UnitOfWork.Servises;

namespace UnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IClassDb1Repository Class1Repositories { get; }
        public IClassDb2Repository Class2Repositories { get; }
        public IClassDb3Repository Class3Repositories { get; }
        public IClassDb4Repository Class4Repositories { get; }
        public IClassDb5Repository Class5Repositories { get; }

        public UnitOfWork(ApplicationDbContext context, IClassDb1Repository class1Repositories, IClassDb2Repository class2Repositories, IClassDb3Repository class3Repositories, IClassDb4Repository class4Repositories, IClassDb5Repository class5Repositories)
        {
            _context = context;
            Class1Repositories = class1Repositories;
            Class2Repositories = class2Repositories;
            Class3Repositories = class3Repositories;
            Class4Repositories = class4Repositories;
            Class5Repositories = class5Repositories;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
