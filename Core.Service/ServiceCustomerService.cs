using Core.Data;


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
