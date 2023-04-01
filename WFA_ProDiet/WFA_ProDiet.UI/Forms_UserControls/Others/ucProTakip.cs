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

namespace WFA_ProDiet.UI
{
    public partial class ucProTakip : UserControl
    {
        public ucProTakip()
        {
            InitializeComponent();
            lblTargetKcalBF.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.25).ToString();
            lblTargetKcalDinner.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.375).ToString();
            lblTargetKcalLunch.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.375).ToString();
            Meal calorie = CrudProcess.Search<Meal>(x => x.EatDay == dtpMealDate.Value.Date && x.Name == MealName.Breakfast).FirstOrDefault();
            if (calorie != null)
            {
                lblCurrentKcalBF.Text = calorie.MealCalorie.ToString();
            }
            else
            {
                lblBreakfast.Text = "0";
            }
        }
        private void btnAddBreakFast_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblBreakfast.Text, dtpMealDate.Value);
        }
        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblLunch.Text, dtpMealDate.Value);
        }
        private void btnAddDinner_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblDinner.Text, dtpMealDate.Value);
        }
        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblExtra.Text, dtpMealDate.Value);
        }
        private void ShowDialogAddMeals(string mealName, DateTime date)
        {
            AddMeals addMeals = new AddMeals(mealName, date);
            addMeals.ShowDialog();
        }

        private void pnlCurrentKcal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
