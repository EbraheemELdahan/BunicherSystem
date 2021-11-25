using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Models
{
  public  class ServiceCustomer
    {
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Customer Customer { get; set; }
        public Service Service { get; set; }
    }
}
