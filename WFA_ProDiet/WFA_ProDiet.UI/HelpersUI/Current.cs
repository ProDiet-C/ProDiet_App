using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.UI.HelpersUI
{
    public static class Current
    {
        public static Customer Customer { get; set; }

        public static void CustomerCalculateBmr(Customer customer)
        {
            if (customer.Gender == Gender.Man)
            {
                customer.Bmr = (10 * customer.Weight) + (6.25 * customer.Height) - (5 * (DateTime.Now.Year - customer.BirthDate.Year)) + 5;
            }
            else
            {
                customer.Bmr = (10 * customer.Weight) + (6.25 * customer.Height) - (5 * (DateTime.Now.Year - customer.BirthDate.Year)) - 161;
            };
        }
        public static void CustomerCalculateNeedKcal(Customer customer)
        {
            TimeSpan diffDate = customer.TargetDate.Date - DateTime.Now.Date; // gerekli gün sayısı
            int difDay = diffDate.Days;

            customer.TargetCalorie = customer.Bmr + ((customer.TargetWeight - customer.Weight) * 7000) / (difDay); // günde harcaması gereken kalori

            if (customer.TargetCalorie < 1200)
            {
                customer.TargetCalorie = 1200;
                MessageBox.Show("Hedef kiloya ulaşmak için bu süre sağlığınız için uygun değildir. Sizin için en yakın tarihi biz seçtik!");
            }
            else if (customer.TargetCalorie > 2500)
            {
                customer.TargetCalorie = 2500;
                MessageBox.Show("Hedef kiloya ulaşmak için bu süre sağlığınız için uygun değildir. Sizin için en yakın tarihi biz seçtik!");
            }

            if (customer.TargetCalorie != customer.Bmr) // hedef kilosunda ise
            {
                difDay = (int)(((customer.TargetWeight - customer.Weight) * 7000) / (customer.TargetCalorie - customer.Bmr)) + 1; // gereken gün hesaplandı 
            }
            customer.TargetDate = DateTime.Now.AddDays(difDay); // datetimepickerda seçildi.
        }

        public static void CustomerCreatePlan(int height, double currentWeight, double targetWeight, DateTime targetDate, Customer customer)
        {
            customer.Height = height;
            customer.Weight = currentWeight;
            customer.TargetWeight = targetWeight;
            customer.TargetDate = targetDate;
        }
    }
}
