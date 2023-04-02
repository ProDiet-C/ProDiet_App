using Microsoft.VisualBasic;
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
        public AddMeals(string mealName, DateTime dateTime)
        {
            InitializeComponent();
            lblMealName.Text = mealName;
            dtpMealDate.Value = dateTime;
        }
        Meal meal = null;
        private void AddMeals_Load(object sender, EventArgs e)
        {
            dgvFoods.DataSource = CrudProcess.GetAll<Food>();
            txtFood.Text = "";
            meal = ProDietDb._context.Meals.Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
        
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Food food = (Food)dgvFoods.CurrentRow.DataBoundItem;
           // Meal ml = CrudProcess.GetAll<Meal>().Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();
            MealDetail md = CrudProcess.GetAll<MealDetail>().Where(x => x.Food == food && x.Meal == meal).FirstOrDefault();
            if (md == null)//bu öğün aynı yemekten içeriyor mu?
            {
                double quantity = (double)nudQuantity.Value;
               Meal addmeal = null;
                var control = ProDietDb._context.Meals.Where(x => x.EatDay == dtpMealDate.Value.Date && x.Name == GetMealName()).ToList();
                if (control.Count == 0)
                {
                    addmeal = new()
                    {
                        Customer = Current.Customer,
                        CustomerId = Current.Customer.CustomerId,
                        EatDay = dtpMealDate.Value.Date,
                        MealCalorie = (food.Calorie * quantity),
                        MealCarbohydrate = (food.Carbohydrate * quantity),
                        MealProtein = (food.Protein * quantity),
                        MealFat = (food.Fat * quantity)

                    };
                    addmeal.Name = GetMealName();
                    CrudProcess.Add(addmeal);
                }
                else
                {
                    addmeal = ProDietDb._context.Meals.Where(x => x.EatDay == dtpMealDate.Value.Date && x.Name == GetMealName()).FirstOrDefault();
                    addmeal.MealCalorie += (food.Calorie * quantity);
                   addmeal.MealCarbohydrate += (food.Carbohydrate * quantity);
                   addmeal.MealProtein += (food.Protein * quantity);
                    addmeal.MealFat += (food.Fat * quantity);
                    CrudProcess.Edit(addmeal);
                }

                MealDetail mealDetail = new() { Food = food, FoodId = food.FoodId, Meal = addmeal, MealId = addmeal.MealId, Quantity = (int)quantity };

                CrudProcess.Add(mealDetail);
            }
            else
            {
                MessageBox.Show("Seçtiğiniz yemeği daha önce öğününüze eklenmiş, öğününüzdeki yemeğin adetini değişitirmek isterseniz,adet alanından değişklik yapıp yaparak 'GÜNCELLE' butonuna basınız. ");
            }

            lstMealRefresh();
        }
        /*
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
        //}*/

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            //Yemek Arama-ok
            dgvFoods.DataSource = CrudProcess.Search<Food>(x => x.Name.Contains(txtSearchFood.Text));
        }

        private void cbOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fİltreleme-ok
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
        }

        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            lstMealRefresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //meal = CrudProcess.GetAll<Meal>().Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();

            Food newFood = (Food)dgvFoods.CurrentRow.DataBoundItem;
            Food removeFood = (Food)lstDailyMeal.SelectedItem;

            MealDetail updateFoodFromMeal = ProDietDb._context.MealDetails.Where(x => x.Food == removeFood && x.Meal == meal).FirstOrDefault();//???

            if (newFood != null && meal != null && removeFood != null && updateFoodFromMeal != null)
            {
                CrudProcess.Delete(updateFoodFromMeal);

                updateFoodFromMeal.FoodId = newFood.FoodId;
                updateFoodFromMeal.Food = newFood;
                //calori güncelleme
                meal.MealCalorie += ((newFood.Calorie * (double)nudQuantity.Value) - (removeFood.Calorie * updateFoodFromMeal.Quantity));
                meal.MealCarbohydrate += ((newFood.Carbohydrate * (double)nudQuantity.Value) - (removeFood.Carbohydrate * updateFoodFromMeal.Quantity));
                meal.MealProtein += ((newFood.Protein * (double)nudQuantity.Value) - (removeFood.Protein * updateFoodFromMeal.Quantity));
                meal.MealFat += ((newFood.Fat * (double)nudQuantity.Value) - (removeFood.Fat * updateFoodFromMeal.Quantity));

                updateFoodFromMeal.Quantity = (int)nudQuantity.Value;

                CrudProcess.Add(updateFoodFromMeal);


            }
            lstMealRefresh();
        }


        private void lstDailyMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = (Food)lstDailyMeal.SelectedItem;
            nudQuantity.Value = (selectedFood.MealDetails.Where(x => x.Food == selectedFood&&x.Meal==meal).FirstOrDefault().Quantity);

            int foodID = ProDietDb._context.Foods.Where(x => x.FoodId == ((Food)lstDailyMeal.SelectedItem).FoodId).FirstOrDefault().FoodId;

            foreach (DataGridViewRow row in dgvFoods.Rows)//row seçme
            {
                if ((int)row.Cells["FoodId"].Value == foodID)
                {
                    dgvFoods.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    txtFood.Text = row.Cells["Name"].Value.ToString();
                    lblMeasure.Text = row.Cells["MeasureType"].Value.ToString();
                    break;
                }
            }
            //dgvFoods.CurrentCell = dgvFoods.SelectedCells
            //dgvFoods.CurrentCell = dgvFoods.Rows[((Food)lstDailyMeal.SelectedItem).FoodId - 1].Cells[1];

        }
        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            txtFood.Text = dgvFoods.CurrentRow.Cells[1].Value.ToString();
            lblMeasure.Text = dgvFoods.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
           // Meal meal = ProDietDb._context.Meals.Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();
            Food food = ((Food)lstDailyMeal.SelectedItem);
            MealDetail removefood = ProDietDb._context.MealDetails.Where(x => x.Food == food && x.Meal == meal).FirstOrDefault();
            if (food != null && meal != null && meal.MealDetails.Count > 1)//bu dehşet oldu usta dokunmayın, food remove olunca sadece cross tablodan silinir, sonuçta ben yemek silmiyorum öğündeki yememği siliyorum...
            {
                meal.MealCalorie -= (removefood.Food.Calorie * removefood.Quantity);
                meal.MealCarbohydrate -= (food.Carbohydrate * removefood.Quantity);
                meal.MealProtein -= (food.Protein * removefood.Quantity);
                meal.MealFat -= (food.Fat * removefood.Quantity);
                MessageBox.Show($"{food.Name} silindi.");
                CrudProcess.Delete(removefood);
                CrudProcess.Edit(meal);
            }
            else if (food != null && meal != null)
            {
                MessageBox.Show($"{food.Name} silindi.Öğünde yemek kalmadı!");
                CrudProcess.Delete(removefood);
                CrudProcess.Delete(meal);
            }
            lstMealRefresh();
        }
        private MealName GetMealName()
        {
            MealName mealName = MealName.Breakfast;

            if (lblMealName.Text == "KAHVALTI")
                mealName = MealName.Breakfast;
            else if (lblMealName.Text == "ÖĞLE YEMEĞİ")
                mealName = MealName.Lunch;
            else if (lblMealName.Text == "AKŞAM YEMEĞİ")
                mealName = MealName.Dinner;
            else if (lblMealName.Text == "EKSTRA")
                mealName = MealName.Extra;

            return mealName;
        }

        private void lstMealRefresh()
        {
            lstDailyMeal.Items.Clear();
            /*CrudProcess.Search<Meal>
            //Meal meal = ProDietDb._context.Meals.Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();
            */
            var mealDetail = CrudProcess.Search<MealDetail>(x => x.Meal == meal);

            if (meal != null && mealDetail != null)
            {
                var foods = meal.MealDetails.Select(f => f.Food);
                lstDailyMeal.Items.AddRange(foods.ToArray());
            }

        }

        private void Addmeals_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
