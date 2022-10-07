using DotnetEcommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetEcommerce.Data;

public class AppDbContext : DbContext
{
    //Tables definitions
    public DbSet<Adress> Adresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasMany(c => c.Adresses).WithOne();
        modelBuilder.Entity<Order>().HasMany(o => o.OrderDetails).WithOne();
        modelBuilder.Entity<Product>().HasMany(p => p.OrderDetails).WithOne();
    }

}