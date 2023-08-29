namespace UnitOfWork.Servises
{
    public interface IClassDb3Repository
    {
        void Add();
        void Delete();
        void Update();
        void Exist();
        void GetAll();
        void GetById();
    }
}
