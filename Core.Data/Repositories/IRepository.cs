using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll();
        public T GetById(int? Id);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void Commit();
    }
}
