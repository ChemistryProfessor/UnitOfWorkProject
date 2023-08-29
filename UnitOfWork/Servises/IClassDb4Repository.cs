namespace UnitOfWork.Servises
{
    public interface IClassDb4Repository
    {
        void Add();
        void Delete();
        void Update();
        void Exist();
        void GetAll();
        void GetById();
    }
}
