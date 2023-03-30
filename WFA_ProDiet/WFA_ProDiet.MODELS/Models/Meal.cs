using System;
using System.Collections.Generic;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class Meal
    {
        public Meal()
        {
            MealDetails = new HashSet<MealDetail>();
        }
       

        public int MealId { get; set; }
        public MealName Name { get; set; }
        public DateTime EatDay { get; set; }
        public double? MealCalorie { get; set; }
        public double? MealCarbohydrate { get; set; }
        public double? MealProtein { get; set; }
        public double? MealFat { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<MealDetail> MealDetails { get; set; }
    }
}
