using System;
using System.Collections.Generic;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class Food
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();
            
        }

        public int FoodId { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Picture { get; set; }
        public double Calorie { get; set; }
        public double? Carbohydrate { get; set; }
        public double? Fat { get; set; }
        public double? Protein { get; set; }
        public MeasureType MeasureType { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }
    }
}
