using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Core.Model.Models
{
   public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        
        
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }


        [ForeignKey("Service")]
        public int ServiceId { get; set; }


        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Service Service { get; set; }
        public virtual Order Order { get; set; }
    }
}
