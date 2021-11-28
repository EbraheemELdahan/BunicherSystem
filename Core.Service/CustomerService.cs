using Core.Data;
using Core.Model.Models;
using System.Linq;

namespace Core.Service
{
    public class CustomerService:IService<Customer>,ICustomerService
    {
        private readonly IRepositoryWrapper _repowrapper;

        public CustomerService(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }

        public void Add(Customer entity)
        {
            _repowrapper.CustomerRepository.Add(entity);
        }

        public void SaveChanges()
        {
            _repowrapper.CustomerRepository.Commit();
        }

        public void Delete(Customer entity)
        {
            _repowrapper.CustomerRepository.Delete(entity);
        }

        public IQueryable<Customer> GetAll()
        {
           return _repowrapper.CustomerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repowrapper.CustomerRepository.GetById(id);
        }

        public void Update(Customer entity)
        {
            _repowrapper.CustomerRepository.Update(entity);
        }
    }
    public interface ICustomerService : IService<Customer>
    {

    }
   
}
