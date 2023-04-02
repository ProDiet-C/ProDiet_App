using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ProDiet.UI.HelpersUI;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.UI
{
    public partial class UcUserInfo : UserControl
    {
        public UcUserInfo()
        {
            InitializeComponent();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            Current.Customer.FirstName = txtFirstName.Text;
            Current.Customer.LastName = txtLastName.Text;
            Current.Customer.BirthDate = dtpBirthDate.Value.Date;
            Current.Customer.ActivityLevel =(ActivityLevel)cbAktivite.SelectedIndex;
            Current.Customer.Height = (int)nudHeight.Value;
        }
    }
}
