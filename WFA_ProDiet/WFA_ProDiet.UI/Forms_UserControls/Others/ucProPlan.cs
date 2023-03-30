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
    public partial class ucProPlan : UserControl
    {
        public ucProPlan()
        {
            InitializeComponent();
        }

        private void lnkProTakip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new HomePage().btnProTakip_Click(sender, e);
        }
    }
}
