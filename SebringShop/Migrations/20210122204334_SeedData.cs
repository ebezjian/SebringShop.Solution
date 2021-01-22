using Microsoft.EntityFrameworkCore.Migrations;

namespace sebringshop.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "ResturantId", "ResturantAddress", "ResturantDelivery", "ResturantFoodType", "ResturantName" },
                values: new object[,]
                {
                    { 1, "1698 US-27 North, Sebring, FL 33870", true, "Fast Food", "Taco Bell" },
                    { 2, "521 US-27 , Sebring, FL 33870", false, "BBQ", "Cody's Original Roadhouse" },
                    { 3, "4731 Lakeview Dr , Sebring, FL 33870", false, "Mexican", "Don Jose Mexican Restaurant" },
                    { 4, "267 US-27 , Sebring, FL 33870", true, "Mexican", "Oscar's Family Restaurant" },
                    { 5, "721 US-27 , Sebring, FL 33870", false, "Seafood", "Red Lobster" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "ShopAddress", "ShopName", "ShopType" },
                values: new object[,]
                {
                    { 1, "1736 US-27 , Sebring, FL 33870", "Ulta Beauty", "Cosmetic" },
                    { 2, "1748 US-27 , Sebring, FL 33870", "Bed Bath & Beyond", "Home goods" },
                    { 3, "1744 US-27 , Sebring, FL 33870", "Ross Dress for Less", "Clothing" },
                    { 4, "1706 US-27 , Sebring, FL 33870", "Sally Beauty", "Cosmetic" },
                    { 5, "1704 US-27 , Sebring, FL 33870", "Petco", "Pets" },
                    { 6, "1724 US-27 , Sebring, FL 33870", "Marshalls", "Clothing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 6);
        }
    }
}
