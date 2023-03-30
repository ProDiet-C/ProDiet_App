using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Av Hayvanları" },
                    { 2, "Balıklar" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActivityLevel", "BirthDate", "Email", "FirstName", "Gender", "Height", "LastName", "Picture", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "okuzkaan@mail.com", "Oğuz Kağan", 0, 180, "Ünal", null, 1500.0, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 },
                    { 2, 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ikasapoglu@mail.com", "İlkiz", 1, 180, "Kasapoğlu", null, 1500.0, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "Picture", "Protein" },
                values: new object[] { 1, 200.0, 100.0, 1, 15.0, 0, "Bıldırcın", null, 100.0 });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "EatDay", "MealCalorie", "MealCarbohydrate", "MealFat", "MealProtein", "Name", "UserId" },
                values: new object[] { 1, new DateTime(2023, 3, 30, 17, 57, 49, 6, DateTimeKind.Local).AddTicks(6444), 500.0, 200.0, 50.0, 100.0, 0, 1 });

            migrationBuilder.InsertData(
                table: "MealDetails",
                columns: new[] { "FoodID", "MealID", "Quantity" },
                values: new object[] { 1, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealDetails",
                keyColumns: new[] { "FoodID", "MealID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
