using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using st10230365Poe.Models;

namespace st10230365Poe.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.RowKey);  // Define RowKey as primary key

            base.OnModelCreating(modelBuilder);
            }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       
        public DbSet<Order> Orders { get; set; }
        public DbSet<ImageModel> Images { get; set; }
        public DbSet<UserInput> UserInputs { get; set; }
    }
}
