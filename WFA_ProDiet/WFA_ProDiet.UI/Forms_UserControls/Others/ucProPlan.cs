using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        double bmr;
        private void lnkProTakip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HomePage().btnProTakip_Click(sender, e);
        }

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {

        }
        private void CalculateBmr(double weight, int height, int age,bool isMan)
        {
            if (isMan) // kullanıcı erkekse
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5; 
            }
            else // kullanıcı kadınsa
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }


        }
    }
}
