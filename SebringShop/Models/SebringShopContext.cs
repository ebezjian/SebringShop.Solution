using Microsoft.EntityFrameworkCore;

namespace SebringShop.Models
{
  public class SebringShopContext : DbContext
  {
    public SebringShopContext(DbContextOptions<SebringShopContext> options)
      : base (options)
      {

      }
      public DbSet<Resturant> Resturants { get; set; }
      public DbSet<Shop> Shops { get; set; }
  }
}