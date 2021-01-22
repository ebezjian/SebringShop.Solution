﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SebringShop.Models;

namespace sebringshop.Migrations
{
    [DbContext(typeof(SebringShopContext))]
    partial class SebringShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SebringShop.Models.Resturant", b =>
                {
                    b.Property<int>("ResturantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ResturantAddress");

                    b.Property<bool>("ResturantDelivery");

                    b.Property<string>("ResturantFoodType");

                    b.Property<string>("ResturantName");

                    b.HasKey("ResturantId");

                    b.ToTable("Resturants");
                });

            modelBuilder.Entity("SebringShop.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShopAddress");

                    b.Property<string>("ShopName");

                    b.Property<string>("ShopType");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
