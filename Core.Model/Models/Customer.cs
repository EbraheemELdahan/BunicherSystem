using Core.Model.Models.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model.Models
{
    public class Customer : BasicData
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        [ForeignKey("User")]


        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Order> Orders { get; set; }



    }
}
