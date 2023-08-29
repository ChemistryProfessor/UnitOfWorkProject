using System;

namespace UnitOfWork.Servises
{
    public interface IUnitOfWork : IDisposable
    {
        public IClassDb1Repository Class1Repositories { get; }
        public IClassDb2Repository Class2Repositories { get; }
        public IClassDb3Repository Class3Repositories { get; }
        public IClassDb4Repository Class4Repositories { get; }
        public IClassDb5Repository Class5Repositories { get; }

        int Complete();
    }
}
