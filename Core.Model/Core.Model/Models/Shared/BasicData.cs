using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Models.Shared
{
    public class BasicData
    {
        public bool IsDeleted { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
    }
}
