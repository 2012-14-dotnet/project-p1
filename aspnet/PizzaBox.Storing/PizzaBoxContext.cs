using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    private readonly IConfiguration _configuration;

    public DbSet<Store> Stores { get; set; }

    public PizzaBoxContext(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration.GetConnectionString("sqlserver"));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<Store>().HasData(
        new Store() { EntityId = 1, Name = "Texas" },
        new Store() { EntityId = 2, Name = "Maryland" },
        new Store() { EntityId = 3, Name = "Florida" }
      );
    }
  }
}
