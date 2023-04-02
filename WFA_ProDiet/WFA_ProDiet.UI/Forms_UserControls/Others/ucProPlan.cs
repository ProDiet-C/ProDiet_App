using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.UI
{
    public partial class ucProPlan : UserControl
    {
        /*
         *  Mifflin-St. Jeor formülü 

           Erkekler için: BMR = 10 x ağırlık(kg) + 6.25 x boy(cm) - 5 x yaş(yıl) + 5
           Kadınlar için: BMR = 10 x ağırlık(kg) + 6.25 x boy(cm) - 5 x yaş(yıl) - 161
           ( bazal metobolizma hızı )

           BMR * aktiflik düzeyi katsayısı yaparak günlük yaktığı kalori miktarı bulunur.
         */
        public ucProPlan()
        {
            InitializeComponent();
        }

        double bmr; // günlük yakılan kalori
        double alinmasiGerekenKcal; // günlük alınması gereken kalori
        Customer customer;
        private void lnkProTakip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HomePage().btnProTakip_Click(sender, e);
        }

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {
            CalculateNeedKcal(customer);
        }

        private void CalculateNeedKcal(Customer customer)
        {


            TimeSpan diffDate = customer.TargetDate.Date - DateTime.Now.Date; // gerekli gün sayısı
            int difDay = diffDate.Days;

            customer.TargetCalorie = customer.Bmr + ((customer.TargetWeight - customer.Weight) * 7000) / (difDay); // günde harcaması gereken kalori

            if (customer.TargetCalorie < 1200)
            {
                customer.TargetCalorie = 1200;
            }
            else if (customer.TargetCalorie > 2500)
            {
                customer.TargetCalorie = 2500;
            }

            difDay = (int)(((customer.TargetWeight - customer.Weight) * 7000) / (customer.TargetCalorie - customer.Bmr)) + 1; // gereken gün hesaplandı 
            dtpTargetDate.Value = DateTime.Now.AddDays(difDay); // datetimepickerda seçildi.
        }
    }
}