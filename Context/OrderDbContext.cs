using Microsoft.EntityFrameworkCore;
using OrderService.Models.Data;

namespace OrderService.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderItems { get; set; }
      //  public DbSet<Address> Addresses { get; set; }
     //   public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Relazione tra Order e User
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.User)
            //    .WithMany(u => u.Orders)                
            //    .HasForeignKey(o => o.UserId)
            //    .OnDelete(DeleteBehavior.NoAction); 

            // Relazione tra Order e Address
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Address)
            //    .WithMany()
            //    .HasForeignKey(o => o.AddressId)
            //    .OnDelete(DeleteBehavior.NoAction); 

            // Relazione tra OrderProduct e Order
            //modelBuilder.Entity<OrderProduct>()
            //    .HasOne(op => op.Order)
            //    .WithMany(o => o.OrderProducts)
            //    .HasForeignKey(op => op.OrderId)
            //    .OnDelete(DeleteBehavior.NoAction); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
