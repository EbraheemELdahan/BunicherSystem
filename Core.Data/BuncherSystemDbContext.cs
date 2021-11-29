using Core.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Data
{
   public class BuncherSystemDbContext :DbContext
    {
        
        
        public BuncherSystemDbContext(DbContextOptions<BuncherSystemDbContext> Options):base(Options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UsersRoles> UsersRoles { get; set; }

        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsersRoles>().HasKey(a => new { a.UserId, a.RoleId });
        }

    }
}
