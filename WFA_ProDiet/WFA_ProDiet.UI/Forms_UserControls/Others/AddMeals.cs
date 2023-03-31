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
                CustomerId = Current.Customer.CustomerId,
                EatDay = dtpMealDate.Value,
                MealCalorie = (food.Calorie * quantity),
                MealCarbohydrate = (food.Carbohydrate * quantity),
                MealProtein = (food.Protein * quantity),
                MealFat = (food.Fat * quantity)
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

        private void AddMeals_Load(object sender, EventArgs e)
        {
            dgvFoods.DataSource = ProDietDb._context.Foods.ToList();
            DataGridViewSelectedColumnCollection selectedColumns = dgvFoods.SelectedColumns;

            // Her bir seçili sütunun index'ini değiştir
            foreach (DataGridViewColumn column in selectedColumns)
            {
                column.DisplayIndex = 3; // index'i 1 ile değiştir
            }

        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            
            dgvFoods.DataSource = CrudProcess.Search<Food>(x => x.Name.Contains(txtSearchFood.Text));
        }

        private void cbOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderByFilter.SelectedIndex == 0)
            {
                dgvFoods.DataSource = ProDietDb._context.Foods.OrderBy(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 1)
            {
                dgvFoods.DataSource = ProDietDb._context.Foods.OrderBy(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 2)
            {
                dgvFoods.DataSource = ProDietDb._context.Foods.OrderBy(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 3)
            {
                dgvFoods.DataSource = ProDietDb._context.Foods.OrderByDescending(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 4)
            {
                dgvFoods.DataSource = ProDietDb._context.Foods.OrderBy(x => x.Protein).ToList();
            }
            /*
                Ketojenik diyet için ideal(düşük karbonhidrat)0
            Dukan diyeti için ideal(yüksek protein)1
                Kaloriye göre azalan2
                    Kaloriye göre artan3
                Proteine göre azalan4
                Proteine göre artan5
            Karbonhidrata göre azalan6
                Karbonhidrata göre artan
                Yağa göre azalan
                    Yağa göre artan*/
        }

        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            
            lstDailyMeal.DataSource = CrudProcess.Search<Meal>(x => x.EatDay.ToShortDateString() == dtpMealDate.Value.ToShortDateString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Meal meal = (Meal)lstDailyMeal.SelectedItem;
            CrudProcess.Edit<Meal>(meal);
        }
        private void lstMealRefresh()
        {

        }

        private void lstDailyMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFoods.DataSource = lstDailyMeal.SelectedItem;
        }
    }
}
