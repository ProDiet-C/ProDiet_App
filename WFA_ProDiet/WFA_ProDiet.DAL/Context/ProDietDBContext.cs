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
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProDietDB;Trusted_Connection=True;Trust Server Certificate=True");
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

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.TargetDate).HasColumnType("date");
            });

          
        }

    }
}
