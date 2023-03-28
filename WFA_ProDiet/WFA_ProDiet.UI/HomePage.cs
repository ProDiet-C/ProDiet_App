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
    public partial class HomePage : Form
    {
        ucProTakip ucProTakip = new ucProTakip();
        ucProPlan ucProPlan = new ucProPlan();
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
            uc.Dock= DockStyle.Fill;
        }
        private void btnProPlan_Click(object sender, EventArgs e)
        {
           
            RemoveAllUc();
            AddUserControl(ucProPlan);
        }
      

        private void btnProTakip_Click(object sender, EventArgs e)
        {           
            RemoveAllUc();
            AddUserControl(ucProTakip);
        }
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


        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            Opacity = 0.9;         
        }
   

        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            pnlMeals.Visible = !pnlMeals.Visible;
            pnlReports.Visible = false;
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            pnlReports.Visible = !pnlReports.Visible;
            pnlMeals.Visible = false;

        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
        
        }
    }
}
