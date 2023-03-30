using System;
using System.Collections.Generic;
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
        public byte[]? Picture { get; set; } // buraya default propfil resmi atanacak
        public string Email { get; set; } = null!;
        public DateTime? BirthDate { get; set; } = Convert.ToDateTime("1995-01.01");
        public Gender Gender { get; set; } = Gender.Man;
        public int? Height { get; set; } = 170;    
        public double? Weight { get; set; } = 80;
        public ActivityLevel? ActivityLevel { get; set; } = Enums.ActivityLevel.LessActive;
        public double? TargetWeight { get; set; } = 70;
        public DateTime? TargetDate { get; set; } = DateTime.Now.AddDays(365) ;
        public double? TargetCalorie { get; set; } = 1500;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
