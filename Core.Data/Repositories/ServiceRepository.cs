using Core.Model.Models;
using System;
using System.Linq;

namespace Core.Data.Repositories
{
    public class ServiceRepository : IRepository<Service>,IServiceRepository
    {
        private readonly BuncherSystemDbContext _db;

        
        public ServiceRepository(BuncherSystemDbContext db)
        {
            _db = db;
        }
        public void Add(Service entity)
        {
            _db.Services.Add(entity);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Delete(Service entity)
        {
            entity.IsDeleted = true;
        }

        public IQueryable<Service> GetAll()
        {
            return _db.Services.Where(a=>a.IsDeleted==false).OrderByDescending(a=>a.Price).AsQueryable();
        }

        public Service GetById(int? Id)
        {
            return _db.Services.Find(Id);
        }

        public void Update(Service entity)
        {
            _db.Update(entity);
        }
    }
    public interface IServiceRepository:IRepository<Service>
    {

    }
}
