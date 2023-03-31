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
using WFA_ProDiet.UI.HelpersUI;

namespace WFA_ProDiet.UI
{
    public partial class CreateAccount : Form
    {
        string welcomeMessage = "ile sağlıklı yaşama başla.";
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
            this.SetOpacityWhenOpen();
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
            var customer = new Customer()
            {
                FirstName = "Mehmet Mustafa",
                LastName = "Özcan",
                Email = "mehmet@gmail.com",
                Gender = Gender.Woman,
            };
            customer.SetPassword("123456");

            CrudProcess.Add(customer);



            pnlUserInfo.Visible = true;
            tmrOpenForm.Start();
        }
    }
}
