
using Core.Model.Models.Shared;

namespace Core.Model.Models
{
    public class Service :BasicData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool Active { get; set; }
    }
}
