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
    public partial class CreateAccount : Form
    {
        string welcomeMessage = "ile sağlıklı bir yaşama başlayın.";
        int welcomeCounter = 0;
        public CreateAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mouse ile butondan çıkıldığında info açılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        /// <summary>
        /// Mouse ile butondan çıkıldığında info kapanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            tmrWelcome.Start();
            this.TimerOpacity();
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (welcomeCounter < welcomeMessage.Length)
            {
                lblWelcome.Text += welcomeMessage[welcomeCounter++];
            }
            else
            {
                tmrWelcome.Stop();
            }
        }

        private void tmrOpenForm_Tick(object sender, EventArgs e)
        {
            if (Width < 1010)
            {
                Width += 5;
            }
            else
            {
                tmrOpenForm.Stop();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            pnlUserInfo.Visible = true;
            tmrOpenForm.Start();
        }

        private void CreateAccount_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
