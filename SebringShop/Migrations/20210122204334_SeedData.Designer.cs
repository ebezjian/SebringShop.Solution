﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SebringShop.Models;

namespace SebringShop.Migrations
{
    [DbContext(typeof(SebringShopContext))]
    [Migration("20210122204334_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            ResturantId = 1,
                            ResturantAddress = "1698 US-27 North, Sebring, FL 33870",
                            ResturantDelivery = true,
                            ResturantFoodType = "Fast Food",
                            ResturantName = "Taco Bell"
                        },
                        new
                        {
                            ResturantId = 2,
                            ResturantAddress = "521 US-27 , Sebring, FL 33870",
                            ResturantDelivery = false,
                            ResturantFoodType = "BBQ",
                            ResturantName = "Cody's Original Roadhouse"
                        },
                        new
                        {
                            ResturantId = 3,
                            ResturantAddress = "4731 Lakeview Dr , Sebring, FL 33870",
                            ResturantDelivery = false,
                            ResturantFoodType = "Mexican",
                            ResturantName = "Don Jose Mexican Restaurant"
                        },
                        new
                        {
                            ResturantId = 4,
                            ResturantAddress = "267 US-27 , Sebring, FL 33870",
                            ResturantDelivery = true,
                            ResturantFoodType = "Mexican",
                            ResturantName = "Oscar's Family Restaurant"
                        },
                        new
                        {
                            ResturantId = 5,
                            ResturantAddress = "721 US-27 , Sebring, FL 33870",
                            ResturantDelivery = false,
                            ResturantFoodType = "Seafood",
                            ResturantName = "Red Lobster"
                        });
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

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            ShopAddress = "1736 US-27 , Sebring, FL 33870",
                            ShopName = "Ulta Beauty",
                            ShopType = "Cosmetic"
                        },
                        new
                        {
                            ShopId = 2,
                            ShopAddress = "1748 US-27 , Sebring, FL 33870",
                            ShopName = "Bed Bath & Beyond",
                            ShopType = "Home goods"
                        },
                        new
                        {
                            ShopId = 3,
                            ShopAddress = "1744 US-27 , Sebring, FL 33870",
                            ShopName = "Ross Dress for Less",
                            ShopType = "Clothing"
                        },
                        new
                        {
                            ShopId = 4,
                            ShopAddress = "1706 US-27 , Sebring, FL 33870",
                            ShopName = "Sally Beauty",
                            ShopType = "Cosmetic"
                        },
                        new
                        {
                            ShopId = 5,
                            ShopAddress = "1704 US-27 , Sebring, FL 33870",
                            ShopName = "Petco",
                            ShopType = "Pets"
                        },
                        new
                        {
                            ShopId = 6,
                            ShopAddress = "1724 US-27 , Sebring, FL 33870",
                            ShopName = "Marshalls",
                            ShopType = "Clothing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
