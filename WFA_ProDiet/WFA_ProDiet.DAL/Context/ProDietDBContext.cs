using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace WFA_ProDiet.MODELS.Models
{
    public class ProDietDBContext : DbContext
    {
        public ProDietDBContext()
        {
        }

        public ProDietDBContext(DbContextOptions<ProDietDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<Meal> Meals { get; set; } = null!;
        public virtual DbSet<MealDetail> MealDetails { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProDietAppDB;Trusted_Connection=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });


            modelBuilder.Entity<Meal>(entity =>
            {


                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meals_Users");
            });
            //Çoka çok ilişki
            modelBuilder.Entity<MealDetail>(entity =>
            {
                entity.HasKey(e => new { e.MealId, e.FoodId });

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.MealDetails)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MealDetails_Foods");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.MealDetails)
                    .HasForeignKey(d => d.MealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MealDetails_Meals");
            });



            modelBuilder.Entity<User>(entity =>
            {

                entity.Property(e => e.ActivityLevel).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.TargetDate).HasColumnType("date");
            });
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        protected void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "Oğuz Kağan",
                LastName = "Ünal",
                Picture = DAL.MyImage.ball,
                Email = "okuzkaan@mail.com",
                BirthDate = Convert.ToDateTime("2017-01-01"),
                Gender = Enums.Gender.Man,
                Height = 180,
                Weight = 45,
                ActivityLevel = Enums.ActivityLevel.NoActivitiy,
                TargetWeight = 46,
                TargetCalorie = 1500,
                TargetDate = Convert.ToDateTime("2023-02-01")
            },
            new User
            {
                UserId = 2,
                FirstName = "İlkiz",
                LastName = "Kasapoğlu",
                //Picture = Resource1.
                Email = "ikasapoglu@mail.com",
                BirthDate = Convert.ToDateTime("2000-01-01"),
                Gender = Enums.Gender.Woman,
                Height = 180,
                Weight = 45,
                ActivityLevel = Enums.ActivityLevel.MoreActive,
                TargetWeight = 46,
                TargetCalorie = 1500,
                TargetDate = Convert.ToDateTime("2023-05-01")
            }
            );
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                Name = "Av Hayvanları",

            },
            new Category
            {
                CategoryId = 2,
                Name = "Balıklar",
            });
            modelBuilder.Entity<Meal>().HasData(
           new Meal
           {
               MealId = 1,
               Name = Enums.MealName.Breakfast,
               EatDay = DateTime.Now,
               MealCalorie = 500,
               MealCarbohydrate = 200,
               MealProtein = 100,
               MealFat = 50,
               UserId = 1
               
           });
            modelBuilder.Entity<Food>().HasData(
            new Food
            {
                FoodId = 1,
                Name = "Bıldırcın",
                Picture = DAL.MyImage.Bıldırcın,
                Calorie = 200,
                Carbohydrate = 100,
                Fat = 15,
                Protein= 100,   
                MeasureType = Enums.MeasureType.Gram,
                CategoryId = 1,               
                
            });
            modelBuilder.Entity<MealDetail>().HasData(
            new MealDetail
            {               
                MealId = 1,
                FoodId = 1,
                Quantity =3
            });
        }
    }
}
