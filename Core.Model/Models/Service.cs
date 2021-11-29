using Core.Model.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model.Models
{
    public class Service :BasicData
    {
        [Key]
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string  ServiceImage { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }


        public virtual User User { get; set; }
    }
}
