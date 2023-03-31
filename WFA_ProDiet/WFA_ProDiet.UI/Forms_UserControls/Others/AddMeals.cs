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
    public partial class AddMeals : Form
    {
        public AddMeals()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Food food = (Food)dgvFoods.CurrentRow.DataBoundItem;
            double quantity = (double)nudQuantity.Value;
            Meal meal = new()
            {
                Customer = Current.Customer,
                EatDay = dtpMealDate.Value,
                MealCalorie = (food.Calorie * quantity),
                MealCarbohydrate = (food.Carbohydrate * quantity),
                MealProtein = (food.Protein*quantity),
                MealFat = (food.Fat*quantity)
            };            

            if (lblMealName.Text == "KAHVALTI")
                meal.Name = MealName.Breakfast;
            else if (lblMealName.Text == "ÖĞLE YEMEĞİ")
                meal.Name = MealName.Lunch;
            else if (lblMealName.Text == "AKŞAM YEMEĞİ ")
                meal.Name = MealName.Dinner;
            else if (lblMealName.Text == "EXTRA")
                meal.Name = MealName.Extra;
        }
    }
}
