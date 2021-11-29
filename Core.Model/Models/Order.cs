using Core.Model.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model.Models
{
   public class Order:BasicData
    {
        [Key]
        public int OrderId { get; set; }
        public float TotalPrice { get; set; }
        public float Discount { get; set; }
        public float TotalAfterDiscount { get; set; }

       
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
       
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
