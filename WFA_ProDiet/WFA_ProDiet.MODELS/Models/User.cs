using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class User
    {
        public User()
        {
            Meals = new List<Meal>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public byte[]? Picture { get; set; } // buraya default profil resmi atanacak
        public string Email { get; set; } = null!;
        private string Password { get; set; } = null!;
        public DateTime? BirthDate { get; set; } = Convert.ToDateTime("1995-01.01");
        public Gender Gender { get; set; } = Gender.Man;
        public int? Height { get; set; } = 170;    
        public double? Weight { get; set; } = 80;
        public ActivityLevel? ActivityLevel { get; set; } = Enums.ActivityLevel.LessActive;
        public double? TargetWeight { get; set; } = 70;
        public DateTime? TargetDate { get; set; } = DateTime.Now.AddDays(365) ;
        public double? TargetCalorie { get; set; } = 1500;

        public virtual ICollection<Meal> Meals { get; set; }

        public void SetPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                Password = Convert.ToBase64String(hashedBytes);
            }
        }

        public bool VerifyPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = Convert.ToBase64String(hashedBytes);
                return Password == hash;
            }
        }
    }
}
