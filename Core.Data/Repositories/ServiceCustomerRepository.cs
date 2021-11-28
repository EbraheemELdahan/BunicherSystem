using Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    class ServiceCustomerRepository :IServiceCustomerRepository    {
        private readonly BuncherSystemDbContext _db;
        public BuncherSystemDbContext Db => _db;
        public ServiceCustomerRepository(BuncherSystemDbContext db)
        {
            _db = db;
        }

        
    }
    public interface IServiceCustomerRepository
    {
       
    }
}
