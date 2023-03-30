using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    ActivityLevel = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    TargetWeight = table.Column<double>(type: "float", nullable: true),
                    TargetDate = table.Column<DateTime>(type: "date", nullable: true),
                    TargetCalorie = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    MeasureType = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EatDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealCalorie = table.Column<double>(type: "float", nullable: true),
                    MealCarbohydrate = table.Column<double>(type: "float", nullable: true),
                    MealProtein = table.Column<double>(type: "float", nullable: true),
                    MealFat = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "MealDetails",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDetails", x => new { x.MealID, x.FoodID });
                    table.ForeignKey(
                        name: "FK_MealDetails_Foods",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodId");
                    table.ForeignKey(
                        name: "FK_MealDetails_Meals",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealId");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActivityLevel", "BirthDate", "Email", "FirstName", "Gender", "Height", "LastName", "Picture", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[] { 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "okuzkaan@mail.com", "Oğuz Kağan", 0, 180, "Ünal", null, 1500.0, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActivityLevel", "BirthDate", "Email", "FirstName", "Gender", "Height", "LastName", "Picture", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[] { 2, 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ikasapoglu@mail.com", "İlkiz", 1, 180, "Kasapoğlu", null, 1500.0, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetails_FoodID",
                table: "MealDetails",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserId",
                table: "Meals",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealDetails");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
