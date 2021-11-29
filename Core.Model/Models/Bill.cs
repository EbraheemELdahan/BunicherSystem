using Core.Model.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Models
{
    public class Bill : BasicData
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int BillNumber { get; set; }
        public int UserId { get; set; }
        public virtual Customer User { get; set; }

    }
}
