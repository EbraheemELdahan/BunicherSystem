using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
   public class ServiceCustomerService:IServiveCustomer
    {
        private readonly IRepositoryWrapper _repowrapper;
        public IRepositoryWrapper Repowrapper => _repowrapper;


        public ServiceCustomerService(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }

    }
    public interface IServiveCustomer
    {

    }
}
