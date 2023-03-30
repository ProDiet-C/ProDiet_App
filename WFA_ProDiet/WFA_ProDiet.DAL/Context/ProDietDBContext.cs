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
            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(f => f.MeasureType).HasColumnType("nvarchar(50)");
                // entity.Property(f => f.MeasureType).HasColumnType("nvarchar(50)");

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

                entity.Property(e => e.ActivityLevel).HasColumnType("nvarchar(50)");

                entity.Property(e => e.ActivityLevel).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("nvarchar(50)");

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


            new Category() { CategoryId = 1, Name = "Av Hayvanları" },
            new Category() { CategoryId = 2, Name = "Balıklar" },
            new Category() { CategoryId = 3, Name = "Bitkisel Yağlar" },
            new Category() { CategoryId = 4, Name = "Çeşniler" },
            new Category() { CategoryId = 5, Name = "Çorbalar" },
            new Category() { CategoryId = 6, Name = "Deniz Ürünleri" },
            new Category() { CategoryId = 7, Name = "Diğer Besinler" },
            new Category() { CategoryId = 8, Name = "Ekmek Vb. Ürünler" },
            new Category() { CategoryId = 9, Name = "Et Ürünleri" },
            new Category() { CategoryId = 10, Name = "Hayvansal Yağlar" },
            new Category() { CategoryId = 11, Name = "İçecekler" },
            new Category() { CategoryId = 12, Name = "Kırmızı Etler" },
            new Category() { CategoryId = 13, Name = "Kurubaklagiller" },
            new Category() { CategoryId = 14, Name = "Kümes Hayvanları" },
            new Category() { CategoryId = 15, Name = "Meyveler" },
            new Category() { CategoryId = 16, Name = "Peynirler" },
            new Category() { CategoryId = 17, Name = "Sakatatlar" },
            new Category() { CategoryId = 18, Name = "Sebzeler" },
            new Category() { CategoryId = 19, Name = "Soslar" },
            new Category() { CategoryId = 20, Name = "Süt ve Ürünleri" },
            new Category() { CategoryId = 21, Name = "Şeker ve Şeker Ürünleri" },
            new Category() { CategoryId = 22, Name = "Tahıl Ürünleri" },
            new Category() { CategoryId = 23, Name = "Tatlılar" },
            new Category() { CategoryId = 24, Name = "Yumurtalar" }



            );
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
            new Food() { Name = "Bıldırcın", MeasureType = Enums.MeasureType.Gram, Protein = 19.6, Carbohydrate = 0, Fat = 12.1, Calorie = 192, CategoryId = 1 },
            new Food() { Name = "Güvercin", MeasureType = Enums.MeasureType.Gram, Protein = 18.5, Carbohydrate = 0, Fat = 23.8, Calorie = 294, CategoryId = 1 },
            new Food() { Name = "Sülün", MeasureType = Enums.MeasureType.Gram, Protein = 22.7, Carbohydrate = 0, Fat = 9.3, Calorie = 181, CategoryId = 1 },
            new Food() { Name = "Tavşan", MeasureType = Enums.MeasureType.Gram, Protein = 21.0, Carbohydrate = 0, Fat = 8.0, Calorie = 162, CategoryId = 1 },
            new Food() { Name = "Alabalık", MeasureType = Enums.MeasureType.Gram, Protein = 18.3, Carbohydrate = 0, Fat = 9.0, Calorie = 175, CategoryId = 2 },
            new Food() { Name = "Balık Unu", MeasureType = Enums.MeasureType.Gram, Protein = 78.0, Carbohydrate = 0, Fat = 0.3, Calorie = 336, CategoryId = 2 },
            new Food() { Name = "Kalkan", MeasureType = Enums.MeasureType.Gram, Protein = 148.0, Carbohydrate = 0, Fat = 14.4, Calorie = 193, CategoryId = 2 },
            new Food() { Name = "Kılıç", MeasureType = Enums.MeasureType.Gram, Protein = 26.3, Carbohydrate = 0, Fat = 5.6, Calorie = 164, CategoryId = 2 },
            new Food() { Name = "Levrek", MeasureType = Enums.MeasureType.Gram, Protein = 19.2, Carbohydrate = 0, Fat = 1.2, Calorie = 93, CategoryId = 2 },
            new Food() { Name = "Mersin", MeasureType = Enums.MeasureType.Gram, Protein = 17.7, Carbohydrate = 0, Fat = 2.3, Calorie = 96, CategoryId = 2 },
            new Food() { Name = "Palamut", MeasureType = Enums.MeasureType.Gram, Protein = 24.0, Carbohydrate = 0, Fat = 7.3, Calorie = 168, CategoryId = 2 },
            new Food() { Name = "Sardalya", MeasureType = Enums.MeasureType.Gram, Protein = 19.2, Carbohydrate = 0, Fat = 8.6, Calorie = 160, CategoryId = 2 },
            new Food() { Name = "Sardalya (konserve)", MeasureType = Enums.MeasureType.Gram, Protein = 24.0, Carbohydrate = 0, Fat = 11.0, Calorie = 205, CategoryId = 2 },
            new Food() { Name = "Somon", MeasureType = Enums.MeasureType.Gram, Protein = 20.3, Carbohydrate = 0, Fat = 8.2, Calorie = 155, CategoryId = 2 },
            new Food() { Name = "Ton", MeasureType = Enums.MeasureType.Gram, Protein = 22.8, Carbohydrate = 0, Fat = 22.0, Calorie = 289, CategoryId = 2 },
            new Food() { Name = "Tuzlu Balık", MeasureType = Enums.MeasureType.Gram, Protein = 18.5, Carbohydrate = 0, Fat = 25.1, Calorie = 305, CategoryId = 2 },
            new Food() { Name = "Uskumru", MeasureType = Enums.MeasureType.Gram, Protein = 21.9, Carbohydrate = 0, Fat = 7.3, Calorie = 159, CategoryId = 2 },
            new Food() { Name = "Ayçiçeği Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Fındık Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Haşhaş Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Keten tohumu yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Margarin (kahvaltılık)", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0.9, Fat = 80.5, Calorie = 719, CategoryId = 3 },
            new Food() { Name = "Margarin (kahvaltılık)", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 82.0, Calorie = 720, CategoryId = 3 },
            new Food() { Name = "Mısırözü Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Nebati Yağ", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 900, CategoryId = 3 },
            new Food() { Name = "Palmiye Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Pamuk Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Soya Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Susam Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Yerfıstığı Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Zeytin Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 884, CategoryId = 3 },
            new Food() { Name = "Defne Yaprağı", MeasureType = Enums.MeasureType.Gram, Protein = 7.6, Carbohydrate = 75, Fat = 8.4, Calorie = 313, CategoryId = 4 },
            new Food() { Name = "Dere Otu (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 20.0, Carbohydrate = 56, Fat = 4.4, Calorie = 253, CategoryId = 4 },
            new Food() { Name = "Hardal (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 25.0, Carbohydrate = 35, Fat = 29.0, Calorie = 469, CategoryId = 4 },
            new Food() { Name = "Haşhaş Tohumu", MeasureType = Enums.MeasureType.Gram, Protein = 18.0, Carbohydrate = 23.7, Fat = 45.0, Calorie = 533, CategoryId = 4 },
            new Food() { Name = "Hindistan cevizi (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 6.4, Carbohydrate = 50, Fat = 36.3, Calorie = 525, CategoryId = 4 },
            new Food() { Name = "Kabartma tozu", MeasureType = Enums.MeasureType.DessertSpoon, Protein = 0.0, Carbohydrate = 1, Fat = 0.0, Calorie = 5, CategoryId = 4 },
            new Food() { Name = "Karabiber", MeasureType = Enums.MeasureType.Gram, Protein = 11.0, Carbohydrate = 65, Fat = 3.3, Calorie = 255, CategoryId = 4 },
            new Food() { Name = "Karanfil", MeasureType = Enums.MeasureType.Gram, Protein = 6.0, Carbohydrate = 61.2, Fat = 20.1, Calorie = 323, CategoryId = 4 },
            new Food() { Name = "Kekik", MeasureType = Enums.MeasureType.Gram, Protein = 9.1, Carbohydrate = 64, Fat = 7.4, Calorie = 276, CategoryId = 4 },
            new Food() { Name = "Kırmızıbiber (toz)", MeasureType = Enums.MeasureType.Gram, Protein = 12.0, Carbohydrate = 57, Fat = 17.3, Calorie = 318, CategoryId = 4 },
            new Food() { Name = "Kimyon (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 18.0, Carbohydrate = 44.2, Fat = 22.3, Calorie = 375, CategoryId = 4 },
            new Food() { Name = "Kuş üzümü", MeasureType = Enums.MeasureType.Gram, Protein = 1.7, Carbohydrate = 13.1, Fat = 0.1, Calorie = 54, CategoryId = 4 },
            new Food() { Name = "Maydonoz (kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 22.4, Carbohydrate = 52, Fat = 4.4, Calorie = 276, CategoryId = 4 },
            new Food() { Name = "Nane (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 15.1, Carbohydrate = 29.8, Fat = 4.9, Calorie = 245, CategoryId = 4 },
            new Food() { Name = "Safran", MeasureType = Enums.MeasureType.Gram, Protein = 11.4, Carbohydrate = 65, Fat = 6.5, Calorie = 310, CategoryId = 4 },
            new Food() { Name = "Sofra Tuzu", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 0, CategoryId = 4 },
            new Food() { Name = "Tarçın (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 3.9, Carbohydrate = 80, Fat = 3.2, Calorie = 261, CategoryId = 4 },
            new Food() { Name = "Zencefil", MeasureType = Enums.MeasureType.Gram, Protein = 9.1, Carbohydrate = 71, Fat = 6.0, Calorie = 347, CategoryId = 4 },
            new Food() { Name = "Zerdecal", MeasureType = Enums.MeasureType.Gram, Protein = 8.2, Carbohydrate = 65.3, Fat = 10.1, Calorie = 354, CategoryId = 4 },
            new Food() { Name = "Bezelye", MeasureType = Enums.MeasureType.Gram, Protein = 21.0, Carbohydrate = 50, Fat = 1.2, Calorie = 295, CategoryId = 5 },
            new Food() { Name = "Domates", MeasureType = Enums.MeasureType.Gram, Protein = 7.0, Carbohydrate = 45.4, Fat = 1.0, Calorie = 219, CategoryId = 5 },
            new Food() { Name = "Ezogelin", MeasureType = Enums.MeasureType.Gram, Protein = 14.0, Carbohydrate = 51.3, Fat = 1.4, Calorie = 274, CategoryId = 5 },
            new Food() { Name = "İşkembe", MeasureType = Enums.MeasureType.Gram, Protein = 20.0, Carbohydrate = 52, Fat = 6.0, Calorie = 342, CategoryId = 5 },
            new Food() { Name = "Mercimek", MeasureType = Enums.MeasureType.Gram, Protein = 19.0, Carbohydrate = 37.5, Fat = 1.0, Calorie = 235, CategoryId = 5 },
            new Food() { Name = "Sebze", MeasureType = Enums.MeasureType.Gram, Protein = 11.0, Carbohydrate = 43.2, Fat = 1.1, Calorie = 227, CategoryId = 5 },
            new Food() { Name = "Tarhana (Acı)", MeasureType = Enums.MeasureType.Gram, Protein = 12.0, Carbohydrate = 59, Fat = 1.5, Calorie = 290, CategoryId = 5 },
            new Food() { Name = "Tarhana (tatlı)", MeasureType = Enums.MeasureType.Gram, Protein = 8.0, Carbohydrate = 61, Fat = 0.4, Calorie = 280, CategoryId = 5 },
            new Food() { Name = "Yayla", MeasureType = Enums.MeasureType.Gram, Protein = 8.0, Carbohydrate = 52, Fat = 1.3, Calorie = 252, CategoryId = 5 },
            new Food() { Name = "Yulaf çorbası", MeasureType = Enums.MeasureType.Gram, Protein = 6.3, Carbohydrate = 62, Fat = 5.0, Calorie = 318, CategoryId = 5 },
            new Food() { Name = "Havyar", MeasureType = Enums.MeasureType.Gram, Protein = 26.9, Carbohydrate = 3.3, Fat = 15.0, Calorie = 262, CategoryId = 6 },
            new Food() { Name = "İstakoz", MeasureType = Enums.MeasureType.Gram, Protein = 16.9, Carbohydrate = 0.5, Fat = 1.9, Calorie = 91, CategoryId = 6 },
            new Food() { Name = "İstiridye", MeasureType = Enums.MeasureType.Piece, Protein = 5.0, Carbohydrate = 5, Fat = 5.0, Calorie = 90, CategoryId = 6 },
            new Food() { Name = "Karides", MeasureType = Enums.MeasureType.Gram, Protein = 18.1, Carbohydrate = 1.5, Fat = 0.8, Calorie = 91, CategoryId = 6 },
            new Food() { Name = "Midye", MeasureType = Enums.MeasureType.Gram, Protein = 14.1, Carbohydrate = 3.3, Fat = 2.3, Calorie = 95, CategoryId = 6 },
            new Food() { Name = "Yengeç (haşlanmış)", MeasureType = Enums.MeasureType.Gram, Protein = 20.1, Carbohydrate = 0, Fat = 5.2, Calorie = 127, CategoryId = 6 },
            new Food() { Name = "Jelatin", MeasureType = Enums.MeasureType.Gram, Protein = 86.0, Carbohydrate = 0, Fat = 0.1, Calorie = 335, CategoryId = 7 },
            new Food() { Name = "Kakao", MeasureType = Enums.MeasureType.Gram, Protein = 17.0, Carbohydrate = 48.3, Fat = 24.0, Calorie = 299, CategoryId = 7 },
            new Food() { Name = "Maya (kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 36.9, Carbohydrate = 39, Fat = 1.6, Calorie = 282, CategoryId = 7 },
            new Food() { Name = "Maya (Yaş)", MeasureType = Enums.MeasureType.Gram, Protein = 12.0, Carbohydrate = 11, Fat = 0.4, Calorie = 86, CategoryId = 7 },
            new Food() { Name = "Sirke", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 6, Fat = 0.0, Calorie = 12, CategoryId = 7 },
            new Food() { Name = "Tahin", MeasureType = Enums.MeasureType.Gram, Protein = 17.0, Carbohydrate = 21.2, Fat = 53.8, Calorie = 595, CategoryId = 7 },
            new Food() { Name = "Turşu (Salatalık)", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 2, Fat = 0.2, Calorie = 10, CategoryId = 7 },
            new Food() { Name = "Zeytin (Siyah)", MeasureType = Enums.MeasureType.Gram, Protein = 1.8, Carbohydrate = 1.1, Fat = 21.0, Calorie = 207, CategoryId = 7 },
            new Food() { Name = "Zeytin (Yeşil)", MeasureType = Enums.MeasureType.Gram, Protein = 1.5, Carbohydrate = 2.8, Fat = 13.5, Calorie = 144, CategoryId = 7 },
            new Food() { Name = "Ekmek (buğday)", MeasureType = Enums.MeasureType.Gram, Protein = 9.1, Carbohydrate = 56.4, Fat = 0.8, Calorie = 276, CategoryId = 8 },
            new Food() { Name = "Ekmek (çavdar)", MeasureType = Enums.MeasureType.Gram, Protein = 9.1, Carbohydrate = 52.1, Fat = 1.1, Calorie = 243, CategoryId = 8 },
            new Food() { Name = "Ekmek (kepek)", MeasureType = Enums.MeasureType.Slice, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 60, CategoryId = 8 },
            new Food() { Name = "Galeta Unu", MeasureType = Enums.MeasureType.Gram, Protein = 12.6, Carbohydrate = 73.4, Fat = 4.6, Calorie = 392, CategoryId = 8 },
            new Food() { Name = "Gramissini", MeasureType = Enums.MeasureType.Gram, Protein = 12.3, Carbohydrate = 0, Fat = 13.9, Calorie = 433, CategoryId = 8 },
            new Food() { Name = "İrmik", MeasureType = Enums.MeasureType.Gram, Protein = 11.4, Carbohydrate = 77, Fat = 0.9, Calorie = 371, CategoryId = 8 },
            new Food() { Name = "Kraker (Peynirli)", MeasureType = Enums.MeasureType.Gram, Protein = 11.2, Carbohydrate = 60.4, Fat = 21.3, Calorie = 479, CategoryId = 8 },
            new Food() { Name = "Kraker (Sade)", MeasureType = Enums.MeasureType.Gram, Protein = 8.0, Carbohydrate = 73.3, Fat = 9.4, Calorie = 384, CategoryId = 8 },
            new Food() { Name = "Kraker (tuzlu)", MeasureType = Enums.MeasureType.Gram, Protein = 9.8, Carbohydrate = 71.5, Fat = 12.0, Calorie = 433, CategoryId = 8 },
            new Food() { Name = "Makarna", MeasureType = Enums.MeasureType.Gram, Protein = 12.5, Carbohydrate = 75.2, Fat = 1.2, Calorie = 369, CategoryId = 8 },
            new Food() { Name = "Sandviç ekmeği", MeasureType = Enums.MeasureType.Gram, Protein = 8.2, Carbohydrate = 53, Fat = 5.6, Calorie = 298, CategoryId = 8 },
            new Food() { Name = "Yufka", MeasureType = Enums.MeasureType.Gram, Protein = 8.9, Carbohydrate = 63.9, Fat = 0.5, Calorie = 271, CategoryId = 8 },
            new Food() { Name = "Yufka (Böreklik)", MeasureType = Enums.MeasureType.Gram, Protein = 3.1, Carbohydrate = 33, Fat = 0.3, Calorie = 152, CategoryId = 8 },
            new Food() { Name = "Jambon", MeasureType = Enums.MeasureType.Gram, Protein = 17.6, Carbohydrate = 3.1, Fat = 10.6, Calorie = 182, CategoryId = 9 },
            new Food() { Name = "Kavurma", MeasureType = Enums.MeasureType.Gram, Protein = 20.0, Carbohydrate = 0.2, Fat = 65.5, Calorie = 670, CategoryId = 9 },
            new Food() { Name = "Pastırma (çemenli)", MeasureType = Enums.MeasureType.Gram, Protein = 29.5, Carbohydrate = 0, Fat = 13.9, Calorie = 250, CategoryId = 9 },
            new Food() { Name = "Pastırma (çemensiz)", MeasureType = Enums.MeasureType.Gram, Protein = 32.7, Carbohydrate = 0, Fat = 14.9, Calorie = 269, CategoryId = 9 },
            new Food() { Name = "Salam", MeasureType = Enums.MeasureType.Gram, Protein = 23.8, Carbohydrate = 1.2, Fat = 38.1, Calorie = 450, CategoryId = 9 },
            new Food() { Name = "Sosis", MeasureType = Enums.MeasureType.Gram, Protein = 11.3, Carbohydrate = 2.4, Fat = 29.4, Calorie = 322, CategoryId = 9 },
            new Food() { Name = "Sucuk", MeasureType = Enums.MeasureType.Gram, Protein = 21.4, Carbohydrate = 0, Fat = 40.8, Calorie = 452, CategoryId = 9 },
            new Food() { Name = "Balık Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 900, CategoryId = 10 },
            new Food() { Name = "İçyağı", MeasureType = Enums.MeasureType.Gram, Protein = 4.1, Carbohydrate = 0, Fat = 81.8, Calorie = 758, CategoryId = 10 },
            new Food() { Name = "Kuyruk Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 100.0, Calorie = 902, CategoryId = 10 },
            new Food() { Name = "Sade Yağ (erimiş)", MeasureType = Enums.MeasureType.Gram, Protein = 0.3, Carbohydrate = 0, Fat = 98.7, Calorie = 890, CategoryId = 10 },
            new Food() { Name = "Tereyağı", MeasureType = Enums.MeasureType.DessertSpoon, Protein = 0.0, Carbohydrate = 0, Fat = 11.0, Calorie = 100, CategoryId = 10 },
            new Food() { Name = "Adaçayı", MeasureType = Enums.MeasureType.Gram, Protein = 10.6, Carbohydrate = 60.7, Fat = 12.7, Calorie = 315, CategoryId = 11 },
            new Food() { Name = "Beyaz şarap", MeasureType = Enums.MeasureType.Goblet, Protein = 8.0, Carbohydrate = 7, Fat = 11.0, Calorie = 80, CategoryId = 11 },
            new Food() { Name = "Bira", MeasureType = Enums.MeasureType.Piece, Protein = 1.0, Carbohydrate = 13, Fat = 0.0, Calorie = 150, CategoryId = 11 },
            new Food() { Name = "Cin", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 231, CategoryId = 11 },
            new Food() { Name = "Cola (diyet)", MeasureType = Enums.MeasureType.Bottle, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 0, CategoryId = 11 },
            new Food() { Name = "Cola (normal)", MeasureType = Enums.MeasureType.Bottle, Protein = 0.0, Carbohydrate = 41, Fat = 0.0, Calorie = 160, CategoryId = 11 },
            new Food() { Name = "Domates suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.7, Carbohydrate = 3.4, Fat = 0.0, Calorie = 16, CategoryId = 11 },
            new Food() { Name = "Gazoz", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 10, Fat = 0.0, Calorie = 39, CategoryId = 11 },
            new Food() { Name = "Ihlamur", MeasureType = Enums.MeasureType.Gram, Protein = 0.4, Carbohydrate = 6.7, Fat = 1.4, Calorie = 42, CategoryId = 11 },
            new Food() { Name = "Kahve (instant)", MeasureType = Enums.MeasureType.Cup, Protein = 0.0, Carbohydrate = 1, Fat = 0.0, Calorie = 5, CategoryId = 11 },
            new Food() { Name = "Kırmızı şarap", MeasureType = Enums.MeasureType.Goblet, Protein = 0.0, Carbohydrate = 0, Fat = 3.0, Calorie = 75, CategoryId = 11 },
            new Food() { Name = "Limonata", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 5.6, Fat = 0.0, Calorie = 21, CategoryId = 11 },
            new Food() { Name = "Meyve suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 8, Fat = 0.0, Calorie = 31, CategoryId = 11 },
            new Food() { Name = "Portakal Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.7, Carbohydrate = 10.4, Fat = 0.2, Calorie = 45, CategoryId = 11 },
            new Food() { Name = "Rose (şarap)", MeasureType = Enums.MeasureType.Gram, Protein = 0.1, Carbohydrate = 2.5, Fat = 0.0, Calorie = 71, CategoryId = 11 },
            new Food() { Name = "Viski", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 263, CategoryId = 11 },
            new Food() { Name = "Votka", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 275, CategoryId = 11 },
            new Food() { Name = "Az yağlı dana eti", MeasureType = Enums.MeasureType.Gram, Protein = 19.7, Carbohydrate = 0, Fat = 8.0, Calorie = 156, CategoryId = 12 },
            new Food() { Name = "Az yağlı domuz eti", MeasureType = Enums.MeasureType.Gram, Protein = 11.2, Carbohydrate = 0, Fat = 47.0, Calorie = 472, CategoryId = 12 },
            new Food() { Name = "Az yağlı koyun eti", MeasureType = Enums.MeasureType.Gram, Protein = 16.8, Carbohydrate = 0, Fat = 19.4, Calorie = 247, CategoryId = 12 },
            new Food() { Name = "Az yağlı sığır eti", MeasureType = Enums.MeasureType.Gram, Protein = 19.4, Carbohydrate = 0, Fat = 15.8, Calorie = 225, CategoryId = 12 },
            new Food() { Name = "Keçi eti", MeasureType = Enums.MeasureType.Gram, Protein = 16.0, Carbohydrate = 0, Fat = 9.0, Calorie = 145, CategoryId = 12 },
            new Food() { Name = "Orta yağlı dana eti", MeasureType = Enums.MeasureType.Gram, Protein = 19.1, Carbohydrate = 0, Fat = 12.0, Calorie = 190, CategoryId = 12 },
            new Food() { Name = "Orta yağlı domuz eti", MeasureType = Enums.MeasureType.Gram, Protein = 10.2, Carbohydrate = 0, Fat = 52.0, Calorie = 513, CategoryId = 12 },
            new Food() { Name = "Orta yağlı koyun eti", MeasureType = Enums.MeasureType.Gram, Protein = 16.5, Carbohydrate = 0, Fat = 21.3, Calorie = 263, CategoryId = 12 },
            new Food() { Name = "Orta yağlı sığır eti", MeasureType = Enums.MeasureType.Gram, Protein = 18.5, Carbohydrate = 0, Fat = 20.4, Calorie = 263, CategoryId = 12 },
            new Food() { Name = "Yağlı dana eti", MeasureType = Enums.MeasureType.Gram, Protein = 18.5, Carbohydrate = 0, Fat = 16.0, Calorie = 223, CategoryId = 12 },
            new Food() { Name = "Yağlı domuz eti", MeasureType = Enums.MeasureType.Gram, Protein = 9.1, Carbohydrate = 0, Fat = 57.0, Calorie = 553, CategoryId = 12 },
            new Food() { Name = "Yağlı koyun eti", MeasureType = Enums.MeasureType.Gram, Protein = 15.4, Carbohydrate = 0, Fat = 27.1, Calorie = 310, CategoryId = 12 },
            new Food() { Name = "Yağlı sığır eti", MeasureType = Enums.MeasureType.Gram, Protein = 17.4, Carbohydrate = 0, Fat = 25.0, Calorie = 301, CategoryId = 12 },
            new Food() { Name = "Ay çekirdeği", MeasureType = Enums.MeasureType.Gram, Protein = 24.0, Carbohydrate = 19.9, Fat = 47.3, Calorie = 560, CategoryId = 13 },
            new Food() { Name = "Badem", MeasureType = Enums.MeasureType.Gram, Protein = 18.6, Carbohydrate = 19, Fat = 54.2, Calorie = 598, CategoryId = 13 },
            new Food() { Name = "Bakla (İç)", MeasureType = Enums.MeasureType.Gram, Protein = 25.1, Carbohydrate = 58.2, Fat = 1.7, Calorie = 338, CategoryId = 13 },
            new Food() { Name = "Barbunya", MeasureType = Enums.MeasureType.Gram, Protein = 22.9, Carbohydrate = 63, Fat = 1.2, Calorie = 349, CategoryId = 13 },
            new Food() { Name = "Bezelye", MeasureType = Enums.MeasureType.Gram, Protein = 24.2, Carbohydrate = 63, Fat = 1.0, Calorie = 348, CategoryId = 13 },
            new Food() { Name = "Börülce", MeasureType = Enums.MeasureType.Gram, Protein = 22.8, Carbohydrate = 61.7, Fat = 1.5, Calorie = 343, CategoryId = 13 },
            new Food() { Name = "Ceviz", MeasureType = Enums.MeasureType.Gram, Protein = 14.8, Carbohydrate = 15.8, Fat = 64.0, Calorie = 651, CategoryId = 13 },
            new Food() { Name = "Çam Fıstığı", MeasureType = Enums.MeasureType.Gram, Protein = 13.0, Carbohydrate = 20.5, Fat = 60.5, Calorie = 635, CategoryId = 13 },
            new Food() { Name = "Fındık", MeasureType = Enums.MeasureType.Gram, Protein = 12.0, Carbohydrate = 16, Fat = 62.4, Calorie = 634, CategoryId = 13 },
            new Food() { Name = "Fıstık", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 560, CategoryId = 13 },
            new Food() { Name = "Kuru Fasulye (beyaz)", MeasureType = Enums.MeasureType.Gram, Protein = 22.3, Carbohydrate = 61.3, Fat = 1.6, Calorie = 340, CategoryId = 13 },
            new Food() { Name = "Kabak Çekirdeği", MeasureType = Enums.MeasureType.Gram, Protein = 30.0, Carbohydrate = 16.7, Fat = 50.0, Calorie = 610, CategoryId = 13 },
            new Food() { Name = "Kavun,Karpuz Çekirdeği", MeasureType = Enums.MeasureType.Gram, Protein = 25.0, Carbohydrate = 19, Fat = 45.0, Calorie = 581, CategoryId = 13 },
            new Food() { Name = "Kestane", MeasureType = Enums.MeasureType.Gram, Protein = 2.9, Carbohydrate = 42.1, Fat = 1.5, Calorie = 194, CategoryId = 13 },
            new Food() { Name = "Kestane Haşlanmış", MeasureType = Enums.MeasureType.Gram, Protein = 2.0, Carbohydrate = 27.8, Fat = 1.5, Calorie = 131, CategoryId = 13 },
            new Food() { Name = "Kestane Kavrulmuş", MeasureType = Enums.MeasureType.Gram, Protein = 3.2, Carbohydrate = 53, Fat = 2.2, Calorie = 245, CategoryId = 13 },
            new Food() { Name = "Mercimek", MeasureType = Enums.MeasureType.Gram, Protein = 24.7, Carbohydrate = 60.1, Fat = 1.1, Calorie = 340, CategoryId = 13 },
            new Food() { Name = "Nohut", MeasureType = Enums.MeasureType.Gram, Protein = 20.5, Carbohydrate = 61, Fat = 4.8, Calorie = 360, CategoryId = 13 },
            new Food() { Name = "Palamut Çekirdeği", MeasureType = Enums.MeasureType.Gram, Protein = 3.0, Carbohydrate = 57.8, Fat = 2.6, Calorie = 268, CategoryId = 13 },
            new Food() { Name = "Soya Fasulyesi", MeasureType = Enums.MeasureType.Gram, Protein = 34.1, Carbohydrate = 33.5, Fat = 17.7, Calorie = 403, CategoryId = 13 },
            new Food() { Name = "Soya Unu (az yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 43.4, Carbohydrate = 36.6, Fat = 6.7, Calorie = 356, CategoryId = 13 },
            new Food() { Name = "Soya Unu (yağsız)", MeasureType = Enums.MeasureType.Gram, Protein = 47.0, Carbohydrate = 38.1, Fat = 0.9, Calorie = 326, CategoryId = 13 },
            new Food() { Name = "Susam", MeasureType = Enums.MeasureType.Gram, Protein = 18.2, Carbohydrate = 17.6, Fat = 53.4, Calorie = 582, CategoryId = 13 },
            new Food() { Name = "Şam Fıstığı", MeasureType = Enums.MeasureType.Gram, Protein = 19.3, Carbohydrate = 19, Fat = 53.7, Calorie = 594, CategoryId = 13 },
            new Food() { Name = "Yer Fıstığı", MeasureType = Enums.MeasureType.Gram, Protein = 26.2, Carbohydrate = 20.6, Fat = 48.7, Calorie = 582, CategoryId = 13 },
            new Food() { Name = "Hindi, et ve deri", MeasureType = Enums.MeasureType.Gram, Protein = 20.4, Carbohydrate = 0, Fat = 8.0, Calorie = 160, CategoryId = 14 },
            new Food() { Name = "Kaz", MeasureType = Enums.MeasureType.Gram, Protein = 15.9, Carbohydrate = 0, Fat = 33.6, Calorie = 371, CategoryId = 14 },
            new Food() { Name = "Ördek", MeasureType = Enums.MeasureType.Gram, Protein = 11.5, Carbohydrate = 0, Fat = 39.3, Calorie = 404, CategoryId = 14 },
            new Food() { Name = "Şehr. tavuk çorbası", MeasureType = Enums.MeasureType.Portion, Protein = 4.0, Carbohydrate = 9, Fat = 2.0, Calorie = 75, CategoryId = 14 },
            new Food() { Name = "Tavuk Whole", MeasureType = Enums.MeasureType.Gram, Protein = 18.6, Carbohydrate = 0, Fat = 15.1, Calorie = 215, CategoryId = 14 },
            new Food() { Name = "Tavuk beyaz et (derili)", MeasureType = Enums.MeasureType.Gram, Protein = 20.3, Carbohydrate = 0, Fat = 11.1, Calorie = 186, CategoryId = 14 },
            new Food() { Name = "Tavuk beyaz et (derisiz)", MeasureType = Enums.MeasureType.Gram, Protein = 23.2, Carbohydrate = 0, Fat = 1.7, Calorie = 114, CategoryId = 14 },
            new Food() { Name = "Tavuk göğüs kızarmış", MeasureType = Enums.MeasureType.Portion, Protein = 35.0, Carbohydrate = 13, Fat = 18.0, Calorie = 365, CategoryId = 14 },
            new Food() { Name = "Tavuk siyah et derisiz", MeasureType = Enums.MeasureType.Gram, Protein = 20.1, Carbohydrate = 0, Fat = 4.3, Calorie = 125, CategoryId = 14 },
            new Food() { Name = "Tavuk, deri", MeasureType = Enums.MeasureType.Gram, Protein = 13.3, Carbohydrate = 0, Fat = 32.4, Calorie = 349, CategoryId = 14 },
            new Food() { Name = "Tavuk, siyah et (derili)", MeasureType = Enums.MeasureType.Gram, Protein = 16.7, Carbohydrate = 0, Fat = 18.3, Calorie = 237, CategoryId = 14 },
            new Food() { Name = "Ahududu (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 13.6, Fat = 0.5, Calorie = 57, CategoryId = 15 },
            new Food() { Name = "Ahududu (Siyah)", MeasureType = Enums.MeasureType.Gram, Protein = 1.5, Carbohydrate = 15.7, Fat = 1.4, Calorie = 73, CategoryId = 15 },
            new Food() { Name = "Ananas", MeasureType = Enums.MeasureType.Gram, Protein = 0.4, Carbohydrate = 13.6, Fat = 0.2, Calorie = 52, CategoryId = 15 },
            new Food() { Name = "Armut", MeasureType = Enums.MeasureType.Gram, Protein = 0.7, Carbohydrate = 15.3, Fat = 0.4, Calorie = 61, CategoryId = 15 },
            new Food() { Name = "Avokado", MeasureType = Enums.MeasureType.Gram, Protein = 2.1, Carbohydrate = 6.3, Fat = 16.4, Calorie = 167, CategoryId = 15 },
            new Food() { Name = "Ayva", MeasureType = Enums.MeasureType.Gram, Protein = 0.4, Carbohydrate = 15.3, Fat = 0.1, Calorie = 57, CategoryId = 15 },
            new Food() { Name = "Böğürtlen", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 12.9, Fat = 0.9, Calorie = 58, CategoryId = 15 },
            new Food() { Name = "Çilek", MeasureType = Enums.MeasureType.Gram, Protein = 0.7, Carbohydrate = 8.4, Fat = 0.5, Calorie = 37, CategoryId = 15 },
            new Food() { Name = "Dut", MeasureType = Enums.MeasureType.Gram, Protein = 0.9, Carbohydrate = 19.8, Fat = 1.1, Calorie = 93, CategoryId = 15 },
            new Food() { Name = "Elma", MeasureType = Enums.MeasureType.Gram, Protein = 0.2, Carbohydrate = 14.5, Fat = 0.6, Calorie = 58, CategoryId = 15 },
            new Food() { Name = "Elma Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.1, Carbohydrate = 12, Fat = 0.0, Calorie = 47, CategoryId = 15 },
            new Food() { Name = "Erik (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 17.8, Fat = 0.0, Calorie = 66, CategoryId = 15 },
            new Food() { Name = "Erik (Mürdüm)", MeasureType = Enums.MeasureType.Gram, Protein = 0.8, Carbohydrate = 19.7, Fat = 0.2, Calorie = 79, CategoryId = 15 },
            new Food() { Name = "Erik Mürdüm (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 2.1, Carbohydrate = 67.4, Fat = 0.6, Calorie = 255, CategoryId = 15 },
            new Food() { Name = "Erik Pestil", MeasureType = Enums.MeasureType.Gram, Protein = 3.3, Carbohydrate = 91.3, Fat = 0.5, Calorie = 344, CategoryId = 15 },
            new Food() { Name = "Grameyfurt", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 10.6, Fat = 0.1, Calorie = 41, CategoryId = 15 },
            new Food() { Name = "Grameyfurt Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 9.2, Fat = 0.1, Calorie = 39, CategoryId = 15 },
            new Food() { Name = "Hurma", MeasureType = Enums.MeasureType.Gram, Protein = 2.2, Carbohydrate = 72.9, Fat = 0.5, Calorie = 274, CategoryId = 15 },
            new Food() { Name = "Hurma", MeasureType = Enums.MeasureType.Piece, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 15, CategoryId = 15 },
            new Food() { Name = "İncir (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 4.3, Carbohydrate = 69.1, Fat = 1.3, Calorie = 274, CategoryId = 15 },
            new Food() { Name = "İncir (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 20.4, Fat = 0.4, Calorie = 80, CategoryId = 15 },
            new Food() { Name = "Karpuz", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 6.4, Fat = 0.2, Calorie = 26, CategoryId = 15 },
            new Food() { Name = "Kavun", MeasureType = Enums.MeasureType.Gram, Protein = 0.8, Carbohydrate = 7.7, Fat = 0.3, Calorie = 33, CategoryId = 15 },
            new Food() { Name = "Kayısı (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 5.0, Carbohydrate = 66.5, Fat = 0.5, Calorie = 260, CategoryId = 15 },
            new Food() { Name = "Kayısı (Taze)", MeasureType = Enums.MeasureType.Piece, Protein = 0.3, Carbohydrate = 4.3, Fat = 0.1, Calorie = 17, CategoryId = 15 },
            new Food() { Name = "Kayısı Pestil", MeasureType = Enums.MeasureType.Gram, Protein = 5.6, Carbohydrate = 84.6, Fat = 1.0, Calorie = 332, CategoryId = 15 },
            new Food() { Name = "Kiraz", MeasureType = Enums.MeasureType.Piece, Protein = 0.1, Carbohydrate = 1.1, Fat = 0.1, Calorie = 5, CategoryId = 15 },
            new Food() { Name = "Kivi", MeasureType = Enums.MeasureType.Gram, Protein = 0.3, Carbohydrate = 10, Fat = 0.1, Calorie = 30, CategoryId = 15 },
            new Food() { Name = "Limon", MeasureType = Enums.MeasureType.Gram, Protein = 1.1, Carbohydrate = 8.2, Fat = 0.3, Calorie = 27, CategoryId = 15 },
            new Food() { Name = "Limon Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 8, Fat = 0.2, Calorie = 25, CategoryId = 15 },
            new Food() { Name = "Mandalina", MeasureType = Enums.MeasureType.Gram, Protein = 0.8, Carbohydrate = 11.6, Fat = 0.2, Calorie = 46, CategoryId = 15 },
            new Food() { Name = "Mandalina Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 10, Fat = 0.2, Calorie = 43, CategoryId = 15 },
            new Food() { Name = "Muz", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 27, Fat = 1.0, Calorie = 105, CategoryId = 15 },
            new Food() { Name = "Nar", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 16, Fat = 0.3, Calorie = 63, CategoryId = 15 },
            new Food() { Name = "Portakal", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 12.2, Fat = 0.2, Calorie = 49, CategoryId = 15 },
            new Food() { Name = "Şeftali", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 9.7, Fat = 0.1, Calorie = 38, CategoryId = 15 },
            new Food() { Name = "Üzüm (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 2.5, Carbohydrate = 77.4, Fat = 0.2, Calorie = 289, CategoryId = 15 },
            new Food() { Name = "Üzüm (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 17.3, Fat = 0.3, Calorie = 67, CategoryId = 15 },
            new Food() { Name = "Üzüm Suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.2, Carbohydrate = 16.6, Fat = 0.0, Calorie = 66, CategoryId = 15 },
            new Food() { Name = "Vişne", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 14.3, Fat = 0.3, Calorie = 58, CategoryId = 15 },
            new Food() { Name = "Bey. peynir (Edirne)", MeasureType = Enums.MeasureType.Gram, Protein = 15.4, Carbohydrate = 0.8, Fat = 18.2, Calorie = 235, CategoryId = 16 },
            new Food() { Name = "Bey. peynir (Urfa)", MeasureType = Enums.MeasureType.Gram, Protein = 15.2, Carbohydrate = 0.2, Fat = 26.5, Calorie = 312, CategoryId = 16 },
            new Food() { Name = "Bey. peynir (yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 22.5, Carbohydrate = 0, Fat = 21.6, Calorie = 289, CategoryId = 16 },
            new Food() { Name = "Bey.peynir (yağsız)", MeasureType = Enums.MeasureType.Gram, Protein = 19.0, Carbohydrate = 3.8, Fat = 0.7, Calorie = 99, CategoryId = 16 },
            new Food() { Name = "Cheddar", MeasureType = Enums.MeasureType.Gram, Protein = 24.9, Carbohydrate = 1.3, Fat = 33.1, Calorie = 403, CategoryId = 16 },
            new Food() { Name = "Çökelek (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 54.9, Carbohydrate = 13.8, Fat = 11.7, Calorie = 379, CategoryId = 16 },
            new Food() { Name = "Çökelek (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 35.0, Carbohydrate = 3.2, Fat = 5.6, Calorie = 215, CategoryId = 16 },
            new Food() { Name = "Gramavyer (%8 Tuzlu)", MeasureType = Enums.MeasureType.Gram, Protein = 29.8, Carbohydrate = 0.4, Fat = 32.3, Calorie = 413, CategoryId = 16 },
            new Food() { Name = "Kars Tipi", MeasureType = Enums.MeasureType.Gram, Protein = 25.0, Carbohydrate = 1.4, Fat = 27.8, Calorie = 357, CategoryId = 16 },
            new Food() { Name = "Kaşar Peyniri", MeasureType = Enums.MeasureType.Gram, Protein = 27.0, Carbohydrate = 1.4, Fat = 31.7, Calorie = 404, CategoryId = 16 },
            new Food() { Name = "Krem Peynir (Sade)", MeasureType = Enums.MeasureType.Gram, Protein = 7.6, Carbohydrate = 2.7, Fat = 34.9, Calorie = 349, CategoryId = 16 },
            new Food() { Name = "Lor peyniri (%1 yağ)", MeasureType = Enums.MeasureType.Gram, Protein = 12.4, Carbohydrate = 2.7, Fat = 1.0, Calorie = 72, CategoryId = 16 },
            new Food() { Name = "Lor peyniri (%2 yağ)", MeasureType = Enums.MeasureType.Gram, Protein = 13.7, Carbohydrate = 3.6, Fat = 1.9, Calorie = 90, CategoryId = 16 },
            new Food() { Name = "Lor peyniri (yağsız)", MeasureType = Enums.MeasureType.Gram, Protein = 17.3, Carbohydrate = 1.9, Fat = 0.4, Calorie = 85, CategoryId = 16 },
            new Food() { Name = "Otlu Peynir", MeasureType = Enums.MeasureType.Gram, Protein = 20.1, Carbohydrate = 0.5, Fat = 27.3, Calorie = 327, CategoryId = 16 },
            new Food() { Name = "Rokfor", MeasureType = Enums.MeasureType.Gram, Protein = 21.5, Carbohydrate = 2, Fat = 30.6, Calorie = 369, CategoryId = 16 },
            new Food() { Name = "Akciğer (dana)", MeasureType = Enums.MeasureType.Gram, Protein = 16.8, Carbohydrate = 0, Fat = 3.8, Calorie = 106, CategoryId = 17 },
            new Food() { Name = "Beyin", MeasureType = Enums.MeasureType.Gram, Protein = 10.4, Carbohydrate = 0.8, Fat = 8.6, Calorie = 125, CategoryId = 17 },
            new Food() { Name = "Böbrek (kuzu)", MeasureType = Enums.MeasureType.Gram, Protein = 16.8, Carbohydrate = 0.9, Fat = 3.3, Calorie = 105, CategoryId = 17 },
            new Food() { Name = "Dalak (sığır, dana)", MeasureType = Enums.MeasureType.Gram, Protein = 18.1, Carbohydrate = 0, Fat = 3.0, Calorie = 104, CategoryId = 17 },
            new Food() { Name = "Dil (dana)", MeasureType = Enums.MeasureType.Gram, Protein = 18.5, Carbohydrate = 0.9, Fat = 5.3, Calorie = 130, CategoryId = 17 },
            new Food() { Name = "İşkembe (sığır)", MeasureType = Enums.MeasureType.Gram, Protein = 19.1, Carbohydrate = 0, Fat = 2.0, Calorie = 100, CategoryId = 17 },
            new Food() { Name = "Karaciğer (dana)", MeasureType = Enums.MeasureType.Gram, Protein = 19.2, Carbohydrate = 4.1, Fat = 4.7, Calorie = 140, CategoryId = 17 },
            new Food() { Name = "Karaciğer (tavuk)", MeasureType = Enums.MeasureType.Gram, Protein = 19.7, Carbohydrate = 2.9, Fat = 3.7, Calorie = 129, CategoryId = 17 },
            new Food() { Name = "Yürek (dana)", MeasureType = Enums.MeasureType.Gram, Protein = 15.0, Carbohydrate = 1.8, Fat = 5.9, Calorie = 124, CategoryId = 17 },
            new Food() { Name = "Asma Yaprağı", MeasureType = Enums.MeasureType.Gram, Protein = 3.8, Carbohydrate = 15.6, Fat = 1.1, Calorie = 97, CategoryId = 18 },
            new Food() { Name = "Bamya (Kurutulmuş)", MeasureType = Enums.MeasureType.Gram, Protein = 17.4, Carbohydrate = 56.1, Fat = 2.2, Calorie = 266, CategoryId = 18 },
            new Food() { Name = "Bamya (taze)", MeasureType = Enums.MeasureType.Gram, Protein = 2.4, Carbohydrate = 7.6, Fat = 0.3, Calorie = 36, CategoryId = 18 },
            new Food() { Name = "Bezelye (İç)", MeasureType = Enums.MeasureType.Gram, Protein = 6.3, Carbohydrate = 14.4, Fat = 0.4, Calorie = 84, CategoryId = 18 },
            new Food() { Name = "Bezelye (Konserve)", MeasureType = Enums.MeasureType.Gram, Protein = 4.7, Carbohydrate = 16.8, Fat = 0.4, Calorie = 88, CategoryId = 18 },
            new Food() { Name = "Biber (Kurutulmuş)", MeasureType = Enums.MeasureType.Gram, Protein = 16.0, Carbohydrate = 64, Fat = 2.6, Calorie = 293, CategoryId = 18 },
            new Food() { Name = "Biber (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 4.8, Fat = 0.2, Calorie = 22, CategoryId = 18 },
            new Food() { Name = "Börülce (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 9.0, Carbohydrate = 21.8, Fat = 0.8, Calorie = 127, CategoryId = 18 },
            new Food() { Name = "Brokoli", MeasureType = Enums.MeasureType.Head, Protein = 4.0, Carbohydrate = 8, Fat = 1.0, Calorie = 40, CategoryId = 18 },
            new Food() { Name = "Domates (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 5, Fat = 0.2, Calorie = 25, CategoryId = 18 },
            new Food() { Name = "Domates (Yeşil)", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 5.1, Fat = 0.2, Calorie = 24, CategoryId = 18 },
            new Food() { Name = "Domates suyu", MeasureType = Enums.MeasureType.Gram, Protein = 0.8, Carbohydrate = 4.3, Fat = 0.1, Calorie = 19, CategoryId = 18 },
            new Food() { Name = "Ebegümeci", MeasureType = Enums.MeasureType.Gram, Protein = 4.4, Carbohydrate = 4.3, Fat = 0.6, Calorie = 47, CategoryId = 18 },
            new Food() { Name = "Enginar", MeasureType = Enums.MeasureType.Gram, Protein = 3.0, Carbohydrate = 7.8, Fat = 0.2, Calorie = 53, CategoryId = 18 },
            new Food() { Name = "Fasulye (Kurutulmuş)", MeasureType = Enums.MeasureType.Gram, Protein = 8.6, Carbohydrate = 61.1, Fat = 1.7, Calorie = 274, CategoryId = 18 },
            new Food() { Name = "Fasulye (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 1.9, Carbohydrate = 7.1, Fat = 0.2, Calorie = 32, CategoryId = 18 },
            new Food() { Name = "Havuç", MeasureType = Enums.MeasureType.Gram, Protein = 1.1, Carbohydrate = 9.7, Fat = 0.2, Calorie = 42, CategoryId = 18 },
            new Food() { Name = "Hıyar (Soyulmamış)", MeasureType = Enums.MeasureType.Gram, Protein = 0.9, Carbohydrate = 3.4, Fat = 0.1, Calorie = 15, CategoryId = 18 },
            new Food() { Name = "Hıyar (soyulmuş)", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 3.2, Fat = 0.1, Calorie = 14, CategoryId = 18 },
            new Food() { Name = "Hindibağ Otu", MeasureType = Enums.MeasureType.Gram, Protein = 2.7, Carbohydrate = 7.1, Fat = 0.7, Calorie = 53, CategoryId = 18 },
            new Food() { Name = "Ispanak", MeasureType = Enums.MeasureType.Gram, Protein = 3.2, Carbohydrate = 4.3, Fat = 0.3, Calorie = 26, CategoryId = 18 },
            new Food() { Name = "Kabak (Kış)", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 6.5, Fat = 0.1, Calorie = 26, CategoryId = 18 },
            new Food() { Name = "Kabak (Yaz)", MeasureType = Enums.MeasureType.Gram, Protein = 11.0, Carbohydrate = 4.2, Fat = 0.1, Calorie = 19, CategoryId = 18 },
            new Food() { Name = "Karnıbahar", MeasureType = Enums.MeasureType.Gram, Protein = 2.7, Carbohydrate = 5.2, Fat = 0.2, Calorie = 27, CategoryId = 18 },
            new Food() { Name = "Kereviz", MeasureType = Enums.MeasureType.Gram, Protein = 1.8, Carbohydrate = 8.5, Fat = 0.3, Calorie = 40, CategoryId = 18 },
            new Food() { Name = "Kırmızı Biber (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 3.7, Carbohydrate = 18.1, Fat = 2.3, Calorie = 93, CategoryId = 18 },
            new Food() { Name = "Kıvırcık", MeasureType = Enums.MeasureType.Gram, Protein = 1.7, Carbohydrate = 4.1, Fat = 0.1, Calorie = 20, CategoryId = 18 },
            new Food() { Name = "Konserve fasulye", MeasureType = Enums.MeasureType.Gram, Protein = 1.4, Carbohydrate = 5.2, Fat = 0.2, Calorie = 24, CategoryId = 18 },
            new Food() { Name = "Kuşkonmaz", MeasureType = Enums.MeasureType.Gram, Protein = 2.5, Carbohydrate = 5, Fat = 0.2, Calorie = 26, CategoryId = 18 },
            new Food() { Name = "Lahana (Beyaz)", MeasureType = Enums.MeasureType.Gram, Protein = 1.3, Carbohydrate = 5.4, Fat = 0.2, Calorie = 24, CategoryId = 18 },
            new Food() { Name = "Lahana (Brüksel)", MeasureType = Enums.MeasureType.Gram, Protein = 5.2, Carbohydrate = 8, Fat = 0.3, Calorie = 63, CategoryId = 18 },
            new Food() { Name = "Lahana (Kara)", MeasureType = Enums.MeasureType.Gram, Protein = 4.0, Carbohydrate = 5, Fat = 0.3, Calorie = 45, CategoryId = 18 },
            new Food() { Name = "Lahana (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 2.0, Carbohydrate = 6.9, Fat = 0.2, Calorie = 31, CategoryId = 18 },
            new Food() { Name = "Madımak", MeasureType = Enums.MeasureType.Gram, Protein = 2.4, Carbohydrate = 0, Fat = 0.3, Calorie = 22, CategoryId = 18 },
            new Food() { Name = "Mantar", MeasureType = Enums.MeasureType.Gram, Protein = 2.7, Carbohydrate = 4.4, Fat = 0.3, Calorie = 28, CategoryId = 18 },
            new Food() { Name = "Marul", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 2.5, Fat = 0.2, Calorie = 14, CategoryId = 18 },
            new Food() { Name = "Maydonoz", MeasureType = Enums.MeasureType.Gram, Protein = 3.6, Carbohydrate = 8.5, Fat = 0.6, Calorie = 44, CategoryId = 18 },
            new Food() { Name = "Mısır (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 3.5, Carbohydrate = 22.1, Fat = 1.0, Calorie = 96, CategoryId = 18 },
            new Food() { Name = "Nane (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 4.0, Carbohydrate = 7.9, Fat = 1.3, Calorie = 65, CategoryId = 18 },
            new Food() { Name = "Pancar (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 1.6, Carbohydrate = 9.9, Fat = 0.1, Calorie = 43, CategoryId = 18 },
            new Food() { Name = "Pancar (Yaprak)", MeasureType = Enums.MeasureType.Gram, Protein = 2.2, Carbohydrate = 4.6, Fat = 0.3, Calorie = 24, CategoryId = 18 },
            new Food() { Name = "Patates", MeasureType = Enums.MeasureType.Gram, Protein = 2.1, Carbohydrate = 17.1, Fat = 0.1, Calorie = 76, CategoryId = 18 },
            new Food() { Name = "Patates unu", MeasureType = Enums.MeasureType.Gram, Protein = 8.0, Carbohydrate = 80, Fat = 0.8, Calorie = 351, CategoryId = 18 },
            new Food() { Name = "Patlıcan (kurutul.)", MeasureType = Enums.MeasureType.Gram, Protein = 13.7, Carbohydrate = 49, Fat = 2.3, Calorie = 286, CategoryId = 18 },
            new Food() { Name = "Patlıcan (Taze)", MeasureType = Enums.MeasureType.Gram, Protein = 1.2, Carbohydrate = 5.6, Fat = 0.2, Calorie = 25, CategoryId = 18 },
            new Food() { Name = "Pazı", MeasureType = Enums.MeasureType.Gram, Protein = 2.0, Carbohydrate = 4.2, Fat = 0.3, Calorie = 33, CategoryId = 18 },
            new Food() { Name = "Pırasa", MeasureType = Enums.MeasureType.Gram, Protein = 2.2, Carbohydrate = 11.2, Fat = 0.3, Calorie = 52, CategoryId = 18 },
            new Food() { Name = "Roka", MeasureType = Enums.MeasureType.Gram, Protein = 3.0, Carbohydrate = 3.2, Fat = 0.6, Calorie = 33, CategoryId = 18 },
            new Food() { Name = "Sarmısak (Head)", MeasureType = Enums.MeasureType.Gram, Protein = 6.2, Carbohydrate = 30.8, Fat = 0.2, Calorie = 137, CategoryId = 18 },
            new Food() { Name = "Sarmısak (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 16.8, Carbohydrate = 72.7, Fat = 0.8, Calorie = 332, CategoryId = 18 },
            new Food() { Name = "Semiz Otu", MeasureType = Enums.MeasureType.Gram, Protein = 2.0, Carbohydrate = 3.8, Fat = 0.4, Calorie = 32, CategoryId = 18 },
            new Food() { Name = "Soğan (Kuru)", MeasureType = Enums.MeasureType.Gram, Protein = 1.5, Carbohydrate = 8.7, Fat = 0.1, Calorie = 38, CategoryId = 18 },
            new Food() { Name = "Soğan (Toz)", MeasureType = Enums.MeasureType.Gram, Protein = 10.1, Carbohydrate = 80.7, Fat = 1.1, Calorie = 347, CategoryId = 18 },
            new Food() { Name = "Soğan (Yeşil)", MeasureType = Enums.MeasureType.Gram, Protein = 1.5, Carbohydrate = 8.2, Fat = 0.2, Calorie = 36, CategoryId = 18 },
            new Food() { Name = "Şalgam", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 6.6, Fat = 0.2, Calorie = 30, CategoryId = 18 },
            new Food() { Name = "Taze Bakla", MeasureType = Enums.MeasureType.Gram, Protein = 5.2, Carbohydrate = 9.8, Fat = 0.4, Calorie = 72, CategoryId = 18 },
            new Food() { Name = "Tere", MeasureType = Enums.MeasureType.Gram, Protein = 3.0, Carbohydrate = 6, Fat = 1.0, Calorie = 33, CategoryId = 18 },
            new Food() { Name = "Turp (Kırmızı)", MeasureType = Enums.MeasureType.Gram, Protein = 0.9, Carbohydrate = 4.2, Fat = 0.1, Calorie = 19, CategoryId = 18 },
            new Food() { Name = "Turp (Siyah)", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 6.6, Fat = 0.2, Calorie = 30, CategoryId = 18 },
            new Food() { Name = "Yer Elması", MeasureType = Enums.MeasureType.Gram, Protein = 2.3, Carbohydrate = 16.7, Fat = 0.1, Calorie = 75, CategoryId = 18 },
            new Food() { Name = "Yonca", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 9, Fat = 0.6, Calorie = 49, CategoryId = 18 },
            new Food() { Name = "Bin Ada Yağı", MeasureType = Enums.MeasureType.Gram, Protein = 0.9, Carbohydrate = 15.2, Fat = 35.7, Calorie = 377, CategoryId = 19 },
            new Food() { Name = "Fransız salata sosu", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 17.5, Fat = 41.0, Calorie = 430, CategoryId = 19 },
            new Food() { Name = "İtalyan salata sosu", MeasureType = Enums.MeasureType.Gram, Protein = 0.7, Carbohydrate = 10.2, Fat = 48.3, Calorie = 467, CategoryId = 19 },
            new Food() { Name = "Ketçap", MeasureType = Enums.MeasureType.Gram, Protein = 2.0, Carbohydrate = 25.4, Fat = 0.4, Calorie = 106, CategoryId = 19 },
            new Food() { Name = "Kıymalı Chili", MeasureType = Enums.MeasureType.Glass, Protein = 19.0, Carbohydrate = 31, Fat = 16.0, Calorie = 340, CategoryId = 19 },
            new Food() { Name = "Krema (%50 yağ, süt)", MeasureType = Enums.MeasureType.Gram, Protein = 3.2, Carbohydrate = 4.6, Fat = 11.7, Calorie = 134, CategoryId = 19 },
            new Food() { Name = "Mayonez", MeasureType = Enums.MeasureType.Gram, Protein = 0.9, Carbohydrate = 23.9, Fat = 33.4, Calorie = 390, CategoryId = 19 },
            new Food() { Name = "Salata sosu (yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 2.5, Fat = 50.1, Calorie = 449, CategoryId = 19 },
            new Food() { Name = "Salça", MeasureType = Enums.MeasureType.Gram, Protein = 2.7, Carbohydrate = 21.3, Fat = 0.4, Calorie = 98, CategoryId = 19 },
            new Food() { Name = "Soya Sosu", MeasureType = Enums.MeasureType.Gram, Protein = 5.6, Carbohydrate = 9.5, Fat = 1.3, Calorie = 68, CategoryId = 19 },
            new Food() { Name = "Anne sütü", MeasureType = Enums.MeasureType.Gram, Protein = 1.0, Carbohydrate = 6.9, Fat = 4.4, Calorie = 70, CategoryId = 20 },
            new Food() { Name = "İnek (1/2 yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 3.3, Carbohydrate = 4.8, Fat = 1.9, Calorie = 50, CategoryId = 20 },
            new Food() { Name = "İnek (Yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 3.3, Carbohydrate = 4.7, Fat = 3.3, Calorie = 61, CategoryId = 20 },
            new Food() { Name = "İnek (yağsız)", MeasureType = Enums.MeasureType.Gram, Protein = 3.4, Carbohydrate = 4.9, Fat = 0.2, Calorie = 35, CategoryId = 20 },
            new Food() { Name = "Keçi sütü", MeasureType = Enums.MeasureType.Gram, Protein = 3.6, Carbohydrate = 4.5, Fat = 4.1, Calorie = 69, CategoryId = 20 },
            new Food() { Name = "Koyun", MeasureType = Enums.MeasureType.Gram, Protein = 6.0, Carbohydrate = 5.4, Fat = 7.0, Calorie = 108, CategoryId = 20 },
            new Food() { Name = "Manda sütü", MeasureType = Enums.MeasureType.Gram, Protein = 3.8, Carbohydrate = 5.2, Fat = 6.9, Calorie = 97, CategoryId = 20 },
            new Food() { Name = "Soya", MeasureType = Enums.MeasureType.Gram, Protein = 3.4, Carbohydrate = 2.2, Fat = 1.5, Calorie = 33, CategoryId = 20 },
            new Food() { Name = "Süt Tozu (Yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 26.3, Carbohydrate = 38.4, Fat = 26.7, Calorie = 496, CategoryId = 20 },
            new Food() { Name = "Süt Tozu (Yağsız)", MeasureType = Enums.MeasureType.Gram, Protein = 36.2, Carbohydrate = 52, Fat = 0.8, Calorie = 362, CategoryId = 20 },
            new Food() { Name = "Yoğurt (1/2 yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 3.4, Carbohydrate = 5.2, Fat = 1.7, Calorie = 50, CategoryId = 20 },
            new Food() { Name = "Yoğurt (Yağlı)", MeasureType = Enums.MeasureType.Gram, Protein = 3.0, Carbohydrate = 4.9, Fat = 3.4, Calorie = 62, CategoryId = 20 },
            new Food() { Name = "Akide şekeri", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 86.9, Fat = 0.0, Calorie = 330, CategoryId = 21 },
            new Food() { Name = "Bal", MeasureType = Enums.MeasureType.Gram, Protein = 0.3, Carbohydrate = 78.4, Fat = 0.0, Calorie = 315, CategoryId = 21 },
            new Food() { Name = "Bisküvi", MeasureType = Enums.MeasureType.Gram, Protein = 6.6, Carbohydrate = 85.4, Fat = 7.9, Calorie = 418, CategoryId = 21 },
            new Food() { Name = "Bisküvi (pasta)", MeasureType = Enums.MeasureType.Gram, Protein = 5.4, Carbohydrate = 74.4, Fat = 16.1, Calorie = 462, CategoryId = 21 },
            new Food() { Name = "Çikolata (Bademli)", MeasureType = Enums.MeasureType.Gram, Protein = 9.3, Carbohydrate = 51.3, Fat = 35.6, Calorie = 532, CategoryId = 21 },
            new Food() { Name = "Çikolata (Fıstıklı)", MeasureType = Enums.MeasureType.Gram, Protein = 14.1, Carbohydrate = 44.6, Fat = 38.1, Calorie = 543, CategoryId = 21 },
            new Food() { Name = "Çikolata (Şekerli)", MeasureType = Enums.MeasureType.Gram, Protein = 4.4, Carbohydrate = 57.9, Fat = 35.1, Calorie = 528, CategoryId = 21 },
            new Food() { Name = "Çikolata (Şekersiz)", MeasureType = Enums.MeasureType.Gram, Protein = 7.9, Carbohydrate = 46.8, Fat = 39.7, Calorie = 477, CategoryId = 21 },
            new Food() { Name = "Dondurma (Sütlü)", MeasureType = Enums.MeasureType.Gram, Protein = 4.5, Carbohydrate = 20.8, Fat = 10.6, Calorie = 193, CategoryId = 21 },
            new Food() { Name = "Karamela", MeasureType = Enums.MeasureType.Gram, Protein = 4.0, Carbohydrate = 76.6, Fat = 10.2, Calorie = 399, CategoryId = 21 },
            new Food() { Name = "Lokum", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 57, Fat = 1.0, Calorie = 240, CategoryId = 21 },
            new Food() { Name = "Marmelat", MeasureType = Enums.MeasureType.Gram, Protein = 0.5, Carbohydrate = 70.8, Fat = 0.3, Calorie = 278, CategoryId = 21 },
            new Food() { Name = "Meyva şekerleme", MeasureType = Enums.MeasureType.Gram, Protein = 0.4, Carbohydrate = 80.6, Fat = 0.3, Calorie = 316, CategoryId = 21 },
            new Food() { Name = "Pekmez (Üzüm)", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 70.6, Fat = 0.1, Calorie = 293, CategoryId = 21 },
            new Food() { Name = "Reçel", MeasureType = Enums.MeasureType.Gram, Protein = 0.6, Carbohydrate = 70, Fat = 0.1, Calorie = 272, CategoryId = 21 },
            new Food() { Name = "Şeker", MeasureType = Enums.MeasureType.Gram, Protein = 0.0, Carbohydrate = 99.5, Fat = 0.0, Calorie = 385, CategoryId = 21 },
            new Food() { Name = "Tahin helvası", MeasureType = Enums.MeasureType.Gram, Protein = 10.5, Carbohydrate = 53.5, Fat = 28.0, Calorie = 516, CategoryId = 21 },
            new Food() { Name = "Arpa", MeasureType = Enums.MeasureType.Gram, Protein = 8.2, Carbohydrate = 78.8, Fat = 1.0, Calorie = 349, CategoryId = 22 },
            new Food() { Name = "Buğday (aşurelik)", MeasureType = Enums.MeasureType.Gram, Protein = 11.0, Carbohydrate = 72.9, Fat = 2.5, Calorie = 335, CategoryId = 22 },
            new Food() { Name = "Buğday (durum)", MeasureType = Enums.MeasureType.Gram, Protein = 12.7, Carbohydrate = 70.1, Fat = 2.5, Calorie = 332, CategoryId = 22 },
            new Food() { Name = "Bulgur", MeasureType = Enums.MeasureType.Gram, Protein = 10.1, Carbohydrate = 78.1, Fat = 1.2, Calorie = 357, CategoryId = 22 },
            new Food() { Name = "Corn Flakes", MeasureType = Enums.MeasureType.Gram, Protein = 7.9, Carbohydrate = 85.3, Fat = 0.4, Calorie = 386, CategoryId = 22 },
            new Food() { Name = "Çavdar Unu", MeasureType = Enums.MeasureType.Gram, Protein = 3.1, Carbohydrate = 74.8, Fat = 1.7, Calorie = 350, CategoryId = 22 },
            new Food() { Name = "Ekmek (beyaz)", MeasureType = Enums.MeasureType.Slice, Protein = 0.0, Carbohydrate = 0, Fat = 0.0, Calorie = 90, CategoryId = 22 },
            new Food() { Name = "Ekmeklik", MeasureType = Enums.MeasureType.Gram, Protein = 11.8, Carbohydrate = 74.7, Fat = 1.1, Calorie = 365, CategoryId = 22 },
            new Food() { Name = "Kepek", MeasureType = Enums.MeasureType.Gram, Protein = 16.0, Carbohydrate = 61.9, Fat = 4.6, Calorie = 213, CategoryId = 22 },
            new Food() { Name = "Mısır (haşlan.)", MeasureType = Enums.MeasureType.Gram, Protein = 3.3, Carbohydrate = 21, Fat = 1.0, Calorie = 91, CategoryId = 22 },
            new Food() { Name = "Mısır unu", MeasureType = Enums.MeasureType.Gram, Protein = 7.8, Carbohydrate = 76.9, Fat = 2.6, Calorie = 368, CategoryId = 22 },
            new Food() { Name = "Mısır, tane", MeasureType = Enums.MeasureType.Gram, Protein = 11.9, Carbohydrate = 72.1, Fat = 4.7, Calorie = 362, CategoryId = 22 },
            new Food() { Name = "Nişasta", MeasureType = Enums.MeasureType.Gram, Protein = 0.3, Carbohydrate = 87.6, Fat = 0.0, Calorie = 362, CategoryId = 22 },
            new Food() { Name = "Patlamış mısır", MeasureType = Enums.MeasureType.Gram, Protein = 9.8, Carbohydrate = 59.1, Fat = 21.8, Calorie = 456, CategoryId = 22 },
            new Food() { Name = "Pirinç", MeasureType = Enums.MeasureType.Gram, Protein = 6.7, Carbohydrate = 80.4, Fat = 0.4, Calorie = 363, CategoryId = 22 },
            new Food() { Name = "Şehriye", MeasureType = Enums.MeasureType.Gram, Protein = 12.8, Carbohydrate = 72, Fat = 4.6, Calorie = 388, CategoryId = 22 },
            new Food() { Name = "Tarhana", MeasureType = Enums.MeasureType.Gram, Protein = 12.2, Carbohydrate = 56.4, Fat = 4.4, Calorie = 316, CategoryId = 22 },
            new Food() { Name = "Yulaf Unu", MeasureType = Enums.MeasureType.Gram, Protein = 12.0, Carbohydrate = 68, Fat = 75.0, Calorie = 388, CategoryId = 22 },
            new Food() { Name = "Cheesecake", MeasureType = Enums.MeasureType.Slice, Protein = 5.0, Carbohydrate = 26, Fat = 18.0, Calorie = 280, CategoryId = 23 },
            new Food() { Name = "Cheesecake", MeasureType = Enums.MeasureType.Whole, Protein = 60.0, Carbohydrate = 317, Fat = 213.0, Calorie = 3350, CategoryId = 23 },
            new Food() { Name = "Çikolatalı kurabiye", MeasureType = Enums.MeasureType.Piece, Protein = 0.5, Carbohydrate = 7, Fat = 2.0, Calorie = 45, CategoryId = 23 },
            new Food() { Name = "Elmalı turta", MeasureType = Enums.MeasureType.Slice, Protein = 3.0, Carbohydrate = 60, Fat = 18.0, Calorie = 405, CategoryId = 23 },
            new Food() { Name = "Elmalı turta", MeasureType = Enums.MeasureType.Whole, Protein = 21.0, Carbohydrate = 360, Fat = 105.0, Calorie = 2420, CategoryId = 23 },
            new Food() { Name = "Hanımgöbeği", MeasureType = Enums.MeasureType.Gram, Protein = 2.4, Carbohydrate = 33.2, Fat = 7.6, Calorie = 211, CategoryId = 23 },
            new Food() { Name = "Havuçlu kek", MeasureType = Enums.MeasureType.Whole, Protein = 63.0, Carbohydrate = 775, Fat = 328.0, Calorie = 6175, CategoryId = 23 },
            new Food() { Name = "Havuçlu kek", MeasureType = Enums.MeasureType.Slice, Protein = 4.0, Carbohydrate = 48, Fat = 21.0, Calorie = 385, CategoryId = 23 },
            new Food() { Name = "Hurma tatlısı", MeasureType = Enums.MeasureType.Gram, Protein = 4.1, Carbohydrate = 59.4, Fat = 7.1, Calorie = 318, CategoryId = 23 },
            new Food() { Name = "İrmik helvası", MeasureType = Enums.MeasureType.Gram, Protein = 3.8, Carbohydrate = 43.6, Fat = 12.5, Calorie = 302, CategoryId = 23 },
            new Food() { Name = "Jöle", MeasureType = Enums.MeasureType.Gram, Protein = 6.1, Carbohydrate = 62.5, Fat = 0.0, Calorie = 259, CategoryId = 23 },
            new Food() { Name = "Kastırd", MeasureType = Enums.MeasureType.Gram, Protein = 5.9, Carbohydrate = 16.1, Fat = 5.2, Calorie = 126, CategoryId = 23 },
            new Food() { Name = "Kek pasta", MeasureType = Enums.MeasureType.Gram, Protein = 7.5, Carbohydrate = 79.4, Fat = 0.8, Calorie = 364, CategoryId = 23 },
            new Food() { Name = "Muhallebi", MeasureType = Enums.MeasureType.Gram, Protein = 5.1, Carbohydrate = 29.7, Fat = 3.8, Calorie = 173, CategoryId = 23 },
            new Food() { Name = "Sütlaç", MeasureType = Enums.MeasureType.Gram, Protein = 3.4, Carbohydrate = 38, Fat = 2.7, Calorie = 139, CategoryId = 23 },
            new Food() { Name = "Tel kadayıf (fıstıklı)", MeasureType = Enums.MeasureType.Gram, Protein = 4.3, Carbohydrate = 46.7, Fat = 9.1, Calorie = 286, CategoryId = 23 },
            new Food() { Name = "Wafers", MeasureType = Enums.MeasureType.Gram, Protein = 4.7, Carbohydrate = 62.5, Fat = 21.9, Calorie = 535, CategoryId = 23 },
            new Food() { Name = "Bıldırcın yumurta", MeasureType = Enums.MeasureType.Gram, Protein = 13.1, Carbohydrate = 0.4, Fat = 11.1, Calorie = 158, CategoryId = 24 },
            new Food() { Name = "Kaz yumurta", MeasureType = Enums.MeasureType.Gram, Protein = 13.9, Carbohydrate = 1.4, Fat = 13.3, Calorie = 185, CategoryId = 24 },
            new Food() { Name = "Ördek yumurta", MeasureType = Enums.MeasureType.Gram, Protein = 12.8, Carbohydrate = 1.5, Fat = 13.8, Calorie = 185, CategoryId = 24 },
            new Food() { Name = "Tavuk yumurta (beyaz)", MeasureType = Enums.MeasureType.Gram, Protein = 10.1, Carbohydrate = 1.2, Fat = 0.0, Calorie = 49, CategoryId = 24 },
            new Food() { Name = "Tavuk yumurta (sarı)", MeasureType = Enums.MeasureType.Gram, Protein = 16.4, Carbohydrate = 0.2, Fat = 32.9, Calorie = 369, CategoryId = 24 },
            new Food() { Name = "Tavuk yumurta (tam)", MeasureType = Enums.MeasureType.Gram, Protein = 12.1, Carbohydrate = 1.2, Fat = 11.2, Calorie = 158, CategoryId = 24 }


            );
            modelBuilder.Entity<MealDetail>().HasData(
            new MealDetail
            {
                MealId = 1,
                FoodId = 1,
                Quantity = 3
            });
        }
    }
}
