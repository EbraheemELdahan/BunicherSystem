using Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public  class RepositoryWrapper : IRepositoryWrapper
    {
        private ICustomerReposiory _customer;
        private IServiceRepository _service;
        private IUserRepository _user;
        private IServiceCustomerRepository _serviceCustomerRepository;

        private readonly BuncherSystemDbContext _db;
        public RepositoryWrapper(BuncherSystemDbContext db)
        {
            _db = db;

        }
        public ICustomerReposiory CustomerRepository
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_db);
                }
                return _customer;
            }
        }
        public IServiceRepository ServiceRepository
        {


            get
            {
                if (_service == null)
                {
                    _service = new ServiceRepository(_db);
                }
                return _service;

            }
        }
        public  IUserRepository UserRepository
        {


            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_db);
                }
                return _user;

            }
        }
        public IServiceCustomerRepository ServiceCustomerRepository
        {


            get
            {
                if (_user == null)
                {
                    _serviceCustomerRepository = new ServiceCustomerRepository(_db);
                }
                return _serviceCustomerRepository;

            }
        }



        public void Save()
        {
            _db.SaveChanges();
        }
    }
    public interface IRepositoryWrapper
    {
        ICustomerReposiory CustomerRepository { get; }
        IServiceRepository ServiceRepository { get; }
        IUserRepository UserRepository { get; }
        IServiceCustomerRepository ServiceCustomerRepository { get; }
    }
}
