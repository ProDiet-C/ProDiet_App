using System;
using System.Collections.Generic;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class User
    {
        public User()
        {
            Meals = new HashSet<Meal>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public byte[]? Picture { get; set; }
        public string Email { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int? Height { get; set; }
        public double? Weight { get; set; }
        public ActivityLevel? ActivityLevel { get; set; }
        public double? TargetWeight { get; set; }
        public DateTime? TargetDate { get; set; }
        public double? TargetCalorie { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
