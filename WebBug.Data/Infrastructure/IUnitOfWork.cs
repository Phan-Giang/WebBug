namespace WebBug.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}