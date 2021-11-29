

using Core.Model.Models.Shared;

namespace Core.Model.Models
{
    public class User:BasicData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float ValueAddedTax { get; set; }
        public string MoileNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Image { get; set; }

    }
}
