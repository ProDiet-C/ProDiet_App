namespace WFA_ProDiet.UI
{
    public partial class Form1 : Form
    {
        CreateAccount create;
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
            txtPassword
        }
    }
}