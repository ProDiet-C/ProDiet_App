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
            EditUserControl(ucProPlan);       
            EditUserControl(ucProTakip);
        }

        private void EditUserControl(UserControl uc)
        {
            pnlScreen.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;
            uc.Visible = false;
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
            pnlMeals.Visible = pnlMeals.Visible == true ? false : true;
            panel5.Visible = false;
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            panel5.Visible = panel5.Visible == true ? false : true;
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

        private void btnProPlan_Click(object sender, EventArgs e)
        {    
            ChangeVisibleAllUC();
        }

        private void btnProTakip_Click(object sender, EventArgs e)
        {
            ChangeVisibleAllUC();        
           
        }

   
        private void OpenUC(UserControl userControl)
        {
            userControl.Visible = true;
        }

        private void ChangeVisibleAllUC()
        {

            foreach (var uc in pnlScreen.Controls)
            {
                if (uc is UserControl)
                {
                    UserControl changeUc = ((UserControl)uc); // görünürlüğü terse döndürür.
                    //uc.Visible = !changeUc.Visible;
                    changeUc.Visible = changeUc.Visible ? false : true;
                }
             
            
            }
        }

      
    }
}
