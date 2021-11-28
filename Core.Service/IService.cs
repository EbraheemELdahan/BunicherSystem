
using System.Linq;


namespace Core.Service
{
    public interface IService<T>
    {
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void SaveChanges();
    }
}
