using Core.Model.Models.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model.Models
{
    public class User:BasicData
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public float ValueAddedTax { get; set; }
        public string MoileNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }


        public virtual List<Customer> Customers { get; set; }
        public virtual List<Service> Services { get; set; }
        public virtual List<Order> Orders { get; set; }





    }
}
