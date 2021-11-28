using Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    class UserRepository : IRepository<User>,IUserRepository
    {
        private readonly BuncherSystemDbContext _db;

        public UserRepository(BuncherSystemDbContext db)
        {
            _db = db;
        }
        public void Add(User entity)
        {
            _db.Users.Add(entity);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Delete(User entity)
        {
            entity.IsDeleted = true;
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users.Where(a => a.IsDeleted == false).OrderByDescending(a => a.CreationDate).AsQueryable();
        }

        public User GetById(int? Id)
        {
            return _db.Users.Find(Id);
        }

        public void Update(User entity)
        {
            _db.Users.Update(entity);
        }
    }
   public interface IUserRepository:IRepository<User>
    {

    }
}
