using Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>, ICustomerReposiory
    {
        private readonly BuncherSystemDbContext _db;

        public CustomerRepository(BuncherSystemDbContext db)
        {
            _db = db;
        }

        public void Add(Customer entity)
        {
            _db.Add(entity);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            entity.IsDeleted = true;
        }

        public IQueryable<Customer> GetAll()
        {
            return _db.Customers.Where(a => a.IsDeleted == false).OrderByDescending(a => a.CreationDate);
        }

       

        public Customer GetById(int? Id)
        {
            return _db.Customers.Find(Id);
        }

        public void Update(Customer entity)
        {
            _db.Customers.Update(entity);
        }



        public IQueryable<Customer> GetAllCustomersPerDay(string day)
        {
           return _db.Customers.Where(a => a.CreationDate.ToString().Contains(day)).AsQueryable();
        }
    }
    public interface ICustomerReposiory :IRepository<Customer>
    {
        public IQueryable<Customer> GetAllCustomersPerDay(string day);
        
    }
}
