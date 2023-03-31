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
    public partial class UcEditFoods : UserControl
    {
        public UcEditFoods()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Category catagory = ProDietDb._context.Categories.Where(x => x.CategoryId == cbCategory.SelectedIndex).FirstOrDefault();//kategori yakalama

            Food food = new()
            {
                Name = txtFoodName.Text,
                Protein = (double)nudProteinQ.Value,
                Carbohydrate = (double)nudCarbohydrateQ.Value,
                Fat = (double)nudFatQ.Value,
                Calorie = (double)nudCalorieQ.Value,
            };

            food.Category = catagory;
            food.CategoryId = catagory.CategoryId;
            food.MeasureType = (MeasureType)(cbMeasure.SelectedIndex);

            CrudProcess.Add(food);

        }
    }
}
