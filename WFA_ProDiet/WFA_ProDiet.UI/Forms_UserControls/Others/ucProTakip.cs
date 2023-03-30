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
    public partial class ucProTakip : UserControl
    {
        public ucProTakip()
        {
            InitializeComponent();
        }

        private void btnAddBreakFast_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals();
        }
     

        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals();

        }

        private void btnAddDinner_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals();
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals();
        }
        private void ShowDialogAddMeals()
        {
            AddMeals addMeals = new AddMeals();
            addMeals.ShowDialog();
        }
    }
}
