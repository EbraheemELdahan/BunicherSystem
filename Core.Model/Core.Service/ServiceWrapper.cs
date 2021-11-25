using Core.Data;


namespace Core.Service
{
   public class ServiceWrapper :IServiceWrapper
    {
        private readonly IRepositoryWrapper _repowrapper;


        private IUserService _user;
        private ICustomerService _customer;
        private IServicesService _service;
        private IServiveCustomer _serviveCustomer;
        
        public ServiceWrapper(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }
        public ICustomerService CustomerService
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerService(_repowrapper);
                }
                return _customer;

            }

        }
        public IServicesService ServicesService
        {
            get
            {
                if (_service == null)
                {
                    _service = new ServicesService(_repowrapper);
                }
                return _service;

            }

        }
        public IUserService UserService
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserService(_repowrapper);
                }
                return _user;

            }

        }
        public IServiveCustomer ServiveCustomer
        {
            get
            {
                if (_serviveCustomer==null)
                {
                    _serviveCustomer = new ServiceCustomerService(_repowrapper);
                }
                return _serviveCustomer;
               
            }
            
        }

        

        

       
    }
    public interface IServiceWrapper
    {
        IServiveCustomer ServiveCustomer { get; }
        IServicesService ServicesService { get; }
        ICustomerService CustomerService { get; }
        IUserService UserService { get; }
    }
}
