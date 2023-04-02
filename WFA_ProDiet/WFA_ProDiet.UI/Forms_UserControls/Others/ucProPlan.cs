using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using WFA_ProDiet.BLL;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;
using WFA_ProDiet.UI.HelpersUI;

namespace WFA_ProDiet.UI
{
    public partial class ucProPlan : UserControl
    {
        /* Mifflin-St. Jeor formülü 
           Erkekler için: BMR = 10 x ağırlık(kg) + 6.25 x boy(cm) - 5 x yaş(yıl) + 5
           Kadınlar için: BMR = 10 x ağırlık(kg) + 6.25 x boy(cm) - 5 x yaş(yıl) - 161
           ( bazal metobolizma hızı )
           BMR * aktiflik düzeyi katsayısı yaparak günlük yaktığı kalori miktarı bulunur.
         */
        Customer customer = Current.Customer;
        string messagePlan;
        int messageCounter = 0;
        public ucProPlan()
        {
            InitializeComponent();
        }
        private void ucProPlan_Load(object sender, EventArgs e)
        {
            nudHeight.Value = customer.Height;
            nudCurrentWeight.Value = (decimal)customer.Weight;
            nudTargetWeight.Value = (decimal)customer.TargetWeight;
            dtpTargetDate.Value = customer.TargetDate;

        }
        private void lnkProTakip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Pro Takip butonunu tıklamak için HomePage formuna erişiyoruz
            var homePage = this.ParentForm as HomePage;

            // HomePage formunda Pro Takip user control'ünü buluyoruz
            var proTakipControl = homePage.Controls.Find("ucProTakip", true).FirstOrDefault() as ucProTakip;

            // Pro Takip user control'ünün butonunu tıklıyoruz
            homePage.btnProTakip_Click(proTakipControl, EventArgs.Empty);

        }


        private void btnCreatePlan_Click(object sender, EventArgs e)
        {

            messagePlan = "Planınız oluşturuldu ! \n Ulaşmak istediğiniz kilo için kalorisi düşük ürünler tercih etmelisiniz. \n Pro Takip  linkine tıklayarak sürecinizi yönetebilirsiniz.";

            Current.CustomerCreatePlan((int)nudHeight.Value, (double)nudCurrentWeight.Value, (double)nudTargetWeight.Value, dtpTargetDate.Value, customer);
            Current.CustomerCalculateBmr(customer);
            Current.CustomerCalculateNeedKcal(customer);
            CrudProcess.Edit(customer);
            dtpTargetDate.Value = customer.TargetDate;
            lblGainWeigth.Visible = true;
            if (customer.Weight < customer.TargetWeight) // hedef kilonun üstünde ise
            {
                messagePlan = "Planınız oluşturuldu ! \n Ulaşmak istediğiniz kilo için kalorisi yüksek ürünler tercih etmelisiniz. \n Pro Takip  linkine tıklayarak sürecinizi yönetebilirsiniz.";
            }
            else if (customer.Weight == customer.TargetWeight) // hedef kiloda ise
            {
                messagePlan = "Planınız oluşturuldu ! \n Tam olarak hedef kilodasınız tebrikler. \n Pro Takip  linkine tıklayarak sürecinizi yönetebilirsiniz.";
            }

            messageCounter = 0;
            lnkProTakip.Visible = false;
            lblGainWeigth.Text = string.Empty;
            tmrWriteMessage.Start();

        }

        private void tmrWriteMessage_Tick(object sender, EventArgs e)
        {
            lblGainWeigth.Text += messagePlan[messageCounter++];
            if (messageCounter >= messagePlan.Length)
            {
                lnkProTakip.Visible = true;
                tmrWriteMessage.Stop();
            }
        }

      
    }
}