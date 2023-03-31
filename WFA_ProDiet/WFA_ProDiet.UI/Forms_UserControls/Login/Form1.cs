using WFA_ProDiet.BLL;
using WFA_ProDiet.MODELS.Models;
using WFA_ProDiet.UI.HelpersUI;

namespace WFA_ProDiet.UI
{
    public partial class Form1 : Form
    {
        CreateAccount create;
        HomePage homePage;
        public Form1()
        {
            InitializeComponent();
            Opacity= 0;
            tmrFirstOpen.Start();
        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            create = new CreateAccount();
            create.ShowDialog();
        }

        private void tmrFirstOpen_Tick(object sender, EventArgs e)
        {
            if (this.Opacity<=1)
            {
                Opacity += 0.05;
            }
            else
            {
                tmrFirstOpen.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar; // �ifre g�z�k�yorsa maskeler, maskeli ise g�sterir.
            btnShowPassword.IconChar = txtPassword.UseSystemPasswordChar ? FontAwesome.Sharp.IconChar.Lock : FontAwesome.Sharp.IconChar.LockOpen; // �ifre iconu �artlara g�re g�sterilir.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var allCustomer = CrudProcess.GetAll<Customer>();
            var customer = allCustomer.Where(cus=>cus.Email==txtEmail.Text).FirstOrDefault();

            if (customer!=null)
            {
                if (customer.VerifyPassword(txtPassword.Text))
                {
                    Current.Customer= customer;
                    homePage = new HomePage();
                    homePage.Show();
                    HelperUI.SetOpacityWhenOpen(homePage);
                    Hide();
                }
                else
                {
                    MessageBox.Show("�ifreniz hatal�d�r.");
                }
            }
            else 
            {
                MessageBox.Show("Kullan�c� ad� bulunamad�.");
            }
           
        }
    }
}