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
        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ServiceCustomer> ServiceCustomers { get; set; }

    }
}
