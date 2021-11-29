
namespace Core.Model.Models
{
    public class UsersRoles
    {
       
        public int UserId { get; set; }
        public int RoleId { get; set; }


        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}
