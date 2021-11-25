using Core.Model.Models.Shared;

namespace Core.Model.Models
{
    public class Customer : BasicData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
