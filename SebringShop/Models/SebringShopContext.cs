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

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Resturant>()
        .HasData(
          new Resturant {ResturantId = 1, ResturantName = "Taco Bell", ResturantAddress = "1698 US-27 North, Sebring, FL 33870", ResturantFoodType = "Fast Food", ResturantDelivery = true },
          new Resturant {ResturantId = 2, ResturantName = "Cody's Original Roadhouse", ResturantAddress = "521 US-27 , Sebring, FL 33870", ResturantFoodType = "BBQ", ResturantDelivery = false },
          new Resturant {ResturantId = 3, ResturantName = "Don Jose Mexican Restaurant", ResturantAddress = "4731 Lakeview Dr , Sebring, FL 33870", ResturantFoodType = "Mexican", ResturantDelivery = false },
          new Resturant {ResturantId = 4, ResturantName = "Oscar's Family Restaurant", ResturantAddress = "267 US-27 , Sebring, FL 33870", ResturantFoodType = "Mexican", ResturantDelivery = true },
          new Resturant {ResturantId = 5, ResturantName = "Red Lobster", ResturantAddress = "721 US-27 , Sebring, FL 33870", ResturantFoodType = "Seafood", ResturantDelivery = false }
        );
        builder.Entity<Shop>()
        .HasData(
          new Shop {ShopId = 1, ShopName = "Ulta Beauty", ShopAddress = "1736 US-27 , Sebring, FL 33870", ShopType = "Cosmetic"},
          new Shop {ShopId = 2, ShopName = "Bed Bath & Beyond", ShopAddress = "1748 US-27 , Sebring, FL 33870", ShopType = "Home goods"},
          new Shop {ShopId = 3, ShopName = "Ross Dress for Less", ShopAddress = "1744 US-27 , Sebring, FL 33870", ShopType = "Clothing"},
          new Shop {ShopId = 4, ShopName = "Sally Beauty", ShopAddress = "1706 US-27 , Sebring, FL 33870", ShopType = "Cosmetic"},
          new Shop {ShopId = 5, ShopName = "Petco", ShopAddress = "1704 US-27 , Sebring, FL 33870", ShopType = "Pets"},
          new Shop {ShopId = 6, ShopName = "Marshalls", ShopAddress = "1724 US-27 , Sebring, FL 33870", ShopType = "Clothing"}
        );
      }
  }
}