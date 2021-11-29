using Core.Model.Models.Shared;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public class Customer : BasicData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual List<ServiceCustomer>  ServiceCustomers { get; set; }
       
    }
}
