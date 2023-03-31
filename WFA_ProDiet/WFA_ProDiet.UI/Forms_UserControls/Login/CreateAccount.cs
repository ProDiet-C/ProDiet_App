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
        Customer customer;
        List<Customer> customerList = CrudProcess.GetAll<Customer>();
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
            if (Width < 1100)
            {
                Width += 5;
            }
            else
            {
                tmrOpenForm.Stop();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            var password2 = txtPasswordCheck.Text;

            if (password == password2 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber) && password.Any(char.IsPunctuation) && password.Length > 8) // şifre kontrol
            {
                customer = new Customer()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                };
                customer.SetPassword(txtPassword.Text);
                CrudProcess.Add(customer);
                pnlUserInfo.Visible = true;
                tmrOpenForm.Start();
            }
            else
            {
                if (password != password2)
                {

                    MessageBox.Show("Şifreler aynı değil.");
                }
                else
                {
                    MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalı ve şunları içermelidir : \n Büyük Harf\nKüçük Harf\nSayı\nÖzel Karakter ");
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            customer.BirthDate = dtpBirthDate.Value;
            customer.Gender = rbMale.Checked ? Gender.Man : Gender.Woman;
            customer.Height = (int)nudHeight.Value;
            customer.Weight = (double)nudWeight.Value;

            if (cbActivityLevel.SelectedIndex == 0) // aktivite yok
            {
                customer.ActivityLevel = ActivityLevel.NoActivitiy;
            }
            else if (cbActivityLevel.SelectedIndex == 2) // aktif
            {
                customer.ActivityLevel = ActivityLevel.Active;
            }
            else if (cbActivityLevel.SelectedIndex == 3) // çok aktif
            {
                customer.ActivityLevel = ActivityLevel.MoreActive;
            }
            else // az aktif (default) 
            {
                customer.ActivityLevel = ActivityLevel.LessActive;
            }
            CrudProcess.Edit(customer);
            HelperUI.SetOpacityWhenClose(this);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblNameInfo.Visible = false;

            if (txtName.Text.Length<2)
            {
                lblNameInfo.Visible = true;
                lblNameInfo.Text = "Ad en az 2 karakterden oluşmalıdır.";
            }
            else if (!txtName.Text.All(char.IsLetter))
            {
                lblNameInfo.Visible = true;
                lblNameInfo.Text = "Ad sadece harf içerebilir.";
            }
        }        
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastNameInfo.Visible = false;

            if (txtLastName.Text.Length < 2)
            {
                lblLastNameInfo.Visible = true;
                lblLastNameInfo.Text = "Soyad en az 2 karakterden oluşmalıdır.";
            }
            else if (!txtLastName.Text.All(char.IsLetter))
            {
                lblLastNameInfo.Visible = true;
                lblLastNameInfo.Text = "Soyad sadece harf içerebilir.";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblEmailInfo.Visible = false;

            
            if (!(email.Length>8 && email.Contains("@") && email.Contains("."))) // email 8 harften büyük mü ve "@." içeriyor mu kontrolü.
            {
                lblEmailInfo.Visible = true;
                lblEmailInfo.Text = "Email uygun formatta değil";
            }
            else if (customerList.Any(cus=>cus.Email==email)) // bu emailde bir customer var mı kontrolü
            {
                lblEmailInfo.Visible = true;
                lblEmailInfo.Text = "Bu email adresi zaten mevcut.";
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length>11 && password.Any(char.IsDigit) && password.Any(char.IsPunctuation) && password.Any(char.IsUpper) && password.Any(char.IsLower)) 
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Yüksek Güvenlik";
                lblPasswordInfo.ForeColor = Color.DarkGreen;
            }
            else if (password.Length>11)
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Orta Güvenlik";
                lblPasswordInfo.ForeColor = Color.FromArgb(150,170,60);
            }
            else
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Güvenlik Yok";
                lblPasswordInfo.ForeColor = Color.Red;
            }
        }
    }
}
