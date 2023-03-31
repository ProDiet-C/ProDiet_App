using OxyPlot;
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
        public AddMeals(string mealName,DateTime dateTime)
        {
            InitializeComponent();
            lblMealName.Text = mealName;
            dtpMealDate.Value = dateTime;
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
            dgvFoods.DataSource = CrudProcess.GetAll<Food>();
            

          //  lstDailyMeal.DataSource = CrudProcess.Search<Meal>(x => x.EatDay.ToShortDateString() == dtpMealDate.Value.ToShortDateString());

            //int currentRow = dgvFoods.CurrentCell.RowIndex;
            //int currentColumn = dgvFoods.CurrentCell.ColumnIndex;

            //// Sonra başka bir sütuna geçiş yapabiliriz
            //int newColumnIndex = 3; // yeni sütunun indeksi
           

            //DataGridViewSelectedColumnCollection selectedColumns = dgvFoods.SelectedColumns;
            ////dgvFoods.CellFormatting += DgvFoods_CellFormatting;

            //// Her bir seçili sütunun index'ini değiştir
            //foreach (DataGridViewColumn column in selectedColumns)
            //{
            //    column.DisplayIndex = 5; // index'i 1 ile değiştir
            //}

        }

        //DOSYA YOLUNU RESME DÖNÜŞTÜRÜR (DGVFOODS İÇİN)
        //private void DgvFoods_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    // PicturePath sütunu (3. sütun) işleniyor
        //    if (dgvFoods.Columns[e.ColumnIndex].Name == "PicturePath")
        //    {
        //        // Hücredeki değeri al
        //        string picturePath = e.Value.ToString();

        //        // Dosya yolundan bir görüntü oluştur
        //        Image picture = Image.FromFile(picturePath);

        //        // Görüntüyü hücrede göster
        //        e.Value = picture;
        //        e.FormattingApplied = true;
        //    }
        //}

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            
            dgvFoods.DataSource = CrudProcess.Search<Food>(x => x.Name.Contains(txtSearchFood.Text));
        }

        private void cbOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderByFilter.SelectedIndex == 0)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 1)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 2)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 3)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 4)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 5)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 6)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 7)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 8)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Fat).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 9)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Fat).ToList();
            }

            /*
                Ketojenik diyet için ideal(düşük karbonhidrat)0
            Dukan diyeti için ideal(yüksek protein)1
                Kaloriye göre azalan2
                    Kaloriye göre artan3
                Proteine göre azalan4
                Proteine göre artan5
            Karbonhidrata göre azalan6
                Karbonhidrata göre artan7
                Yağa göre azalan8
                    Yağa göre artan9*/
        }

        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            // dgvFoods.CurrentCell = dgvFoods.Rows[5].Cells[2];

            Meal meal = CrudProcess.Search<Meal>(x => x.EatDay.ToShortDateString() == dtpMealDate.Value.ToShortDateString() && x.Name == MealName.Breakfast).FirstOrDefault();

            //var foodNames = meal.MealDetails.Select(x => x.Food.Name).ToList();
            //lstDailyMeal.Items.AddRange(foodNames.ToArray());



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
