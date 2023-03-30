﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WFA_ProDiet.MODELS.Models;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    [DbContext(typeof(ProDietDBContext))]
    [Migration("20230330185605_mig15")]
    partial class mig15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Av Hayvanları"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Balıklar"
                        });
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"), 1L, 1);

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<double?>("Carbohydrate")
                        .HasColumnType("float");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double?>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("MeasureType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Protein")
                        .HasColumnType("float");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Calorie = 200.0,
                            Carbohydrate = 100.0,
                            CategoryId = 1,
                            Fat = 15.0,
                            MeasureType = "Gram",
                            Name = "Bıldırcın",
                            Protein = 100.0
                        });
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"), 1L, 1);

                    b.Property<DateTime>("EatDay")
                        .HasColumnType("datetime2");

                    b.Property<double?>("MealCalorie")
                        .HasColumnType("float");

                    b.Property<double?>("MealCarbohydrate")
                        .HasColumnType("float");

                    b.Property<double?>("MealFat")
                        .HasColumnType("float");

                    b.Property<double?>("MealProtein")
                        .HasColumnType("float");

                    b.Property<int>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            MealId = 1,
                            EatDay = new DateTime(2023, 3, 30, 21, 56, 4, 643, DateTimeKind.Local).AddTicks(9172),
                            MealCalorie = 500.0,
                            MealCarbohydrate = 200.0,
                            MealFat = 50.0,
                            MealProtein = 100.0,
                            Name = 0,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.MealDetail", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int")
                        .HasColumnName("MealID");

                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("FoodID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("MealId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("MealDetails");

                    b.HasData(
                        new
                        {
                            MealId = 1,
                            FoodId = 1,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int?>("ActivityLevel")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.Property<double?>("TargetCalorie")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TargetDate")
                        .HasColumnType("date");

                    b.Property<double?>("TargetWeight")
                        .HasColumnType("float");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ActivityLevel = 0,
                            BirthDate = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "okuzkaan@mail.com",
                            FirstName = "Oğuz Kağan",
                            Gender = 0,
                            Height = 180,
                            LastName = "Ünal",
                            TargetCalorie = 1500.0,
                            TargetDate = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TargetWeight = 46.0,
                            Weight = 45.0
                        },
                        new
                        {
                            UserId = 2,
                            ActivityLevel = 3,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ikasapoglu@mail.com",
                            FirstName = "İlkiz",
                            Gender = 1,
                            Height = 180,
                            LastName = "Kasapoğlu",
                            TargetCalorie = 1500.0,
                            TargetDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TargetWeight = 46.0,
                            Weight = 45.0
                        });
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Food", b =>
                {
                    b.HasOne("WFA_ProDiet.MODELS.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Meal", b =>
                {
                    b.HasOne("WFA_ProDiet.MODELS.Models.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Meals_Users");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.MealDetail", b =>
                {
                    b.HasOne("WFA_ProDiet.MODELS.Models.Food", "Food")
                        .WithMany("MealDetails")
                        .HasForeignKey("FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_MealDetails_Foods");

                    b.HasOne("WFA_ProDiet.MODELS.Models.Meal", "Meal")
                        .WithMany("MealDetails")
                        .HasForeignKey("MealId")
                        .IsRequired()
                        .HasConstraintName("FK_MealDetails_Meals");

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Food", b =>
                {
                    b.Navigation("MealDetails");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.Meal", b =>
                {
                    b.Navigation("MealDetails");
                });

            modelBuilder.Entity("WFA_ProDiet.MODELS.Models.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
