using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ProDiet.BLL;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.UI
{
    public partial class HomePage : Form
    {
        ucProTakip ucProTakip = new ucProTakip();
        ucProPlan ucProPlan = new ucProPlan();
        UcExtraReports ucEkstraReports = new UcExtraReports();
        UcEditFoods ucEditFoods = new UcEditFoods();
        UcDailyReport ucDailyReport = new UcDailyReport();
        UcUserInfo userInfo=new UcUserInfo();
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {


        }

        private void AddUserControl(UserControl uc)
        {
            pnlScreen.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private void btnProPlan_Click(object sender, EventArgs e)
        {

            RemoveAllUc();
            AddUserControl(ucProPlan);
        }

        public void btnProTakip_Click(object sender, EventArgs e)
        {
            RemoveAllUc();
            AddUserControl(ucProTakip);
        }
        private void btnEditFoods_Click(object sender, EventArgs e)
        {
            RemoveAllUc();
            AddUserControl(ucEditFoods);
        }
        private void btnExtraReports_Click(object sender, EventArgs e)
        {
            RemoveAllUc();
            AddUserControl(ucEkstraReports);
        }
        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            RemoveAllUc();
            AddUserControl(ucDailyReport);
        }

        /// <summary>
        /// pnlScreen'in controllerinden tüm UserControlleri siler.
        /// </summary>
        private void RemoveAllUc()
        {
            foreach (var uc in pnlScreen.Controls)
            {
                if (uc is UserControl)
                {
                    pnlScreen.Controls.Remove((UserControl)uc);
                }
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            SetPanelVisibility(pnlMeals);
        }
        private void btnFoods_Click(object sender, EventArgs e)
        {
            SetPanelVisibility(pnlFoods);
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            SetPanelVisibility(pnlReports);
        }

        /// <summary>
        /// Gönderilen panelin görünürlüğünü tersine çevirir, pnlAllMenu içindeki diğer panellerden Tag'ı 1 olanların görünürlüğünü kapatır.
        /// </summary>
        /// <param name="pnlShow"></param>
        private void SetPanelVisibility(Panel pnlShow)
        {
            pnlShow.Visible = !pnlShow.Visible;
            var paneller = pnlAllMenu.Controls.OfType<Panel>().Where(x => x.Tag == "1").ToList();
            foreach (Panel panel in paneller)
            {
                if (panel != pnlShow)
                {
                    panel.Visible = false;
                }
            }
        }
<<<<<<< Updated upstream
=======

        private void btnUser_Click(object sender, EventArgs e)
        {

            RemoveAllUc();
            AddUserControl(userInfo);
        }
>>>>>>> Stashed changes
    }
}
