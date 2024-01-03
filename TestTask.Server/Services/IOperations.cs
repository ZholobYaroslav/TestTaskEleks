using TestTask.Server.Entities;

namespace TestTask.Server.Services
{
    public interface IOperations<T> where T : class
    {
        ICollection<T> GetAll();
        void Create(T item);
        T Update(T Item);
        T Get(int id);
        void Delete(int id);
    }
}
