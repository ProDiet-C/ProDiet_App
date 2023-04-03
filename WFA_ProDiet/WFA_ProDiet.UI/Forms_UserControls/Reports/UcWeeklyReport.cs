using Microsoft.Graph.Models;
using OxyPlot.Axes;
using OxyPlot.Series;
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
using WFA_ProDiet.UI.HelpersUI;
using WFA_ProDiet.MODELS.Models;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Beta_Dist;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.UI
{
    public partial class UcWeeklyReport : UserControl
    {
        public UcWeeklyReport()
        {
            InitializeComponent();

        }

        PlotModel plotModel; LineSeries userSeries; LineSeries avgSeries;
        List<Category> _categories = CrudProcess.GetAll<Category>();
        List<Meal> resultMeals;
        List<Meal> _meals = CrudProcess.GetAll<Meal>();
        Category category;
        Meal meal;
        DateTime today = DateTime.Now;
        List<Customer> customers = CrudProcess.GetAll<Customer>();

        double[] userCalories = new double[7];
        double[] avgCalories = new double[7];
        private void btnCompareByCalorie_Click(object sender, EventArgs e)
        {
            DrawAndShowGraph();
        }
        ProDietDBContext _pro = new ProDietDBContext();
        private void DrawAndShowGraph()
        {
            SetGraphTittle();
            FindCategoryOrCategories();
            FindMeals();

            if (category != null) // categori seçildi ise
            {
                if (rbAll.Checked) // öğün seçmezse
                {
                    KategoriSeçiliOgünNull();
                }
                else // öğün seçili ise
                {

                }
            }
            else // categori seçilmedi ise
            {
                if (rbAll.Checked) // öğün seçmezse
                {
                    CategoryVeOgunNull();
                }
                else // öğün seçtiyse
                {
                    for (int i = 6; i > 0; i--)
                    {
                        userCalories[i] = Convert.ToDouble(Current.Customer.Meals.Where(m => m.Name == resultMeals[0].Name && m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(m => m.MealCalorie));

                        var meals = CrudProcess.GetAll<Meal>().Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).ToList();
                        var customerMeals = meals.GroupBy(m => m.CustomerId).Select(g => new
                        {
                            CustomerId = g.Key,
                            TotalCalories = g.Sum(m => m.MealCalorie)
                        }).ToList();

                        avgCalories[i] = Convert.ToDouble(customerMeals.Average(cmeal => cmeal.TotalCalories));
                    }
                }
            }
            DrawGraph();
        }
        private void CategoryVeOgunNull()
        {
            for (int i = 6; i >= 0; i--)
            {
                userCalories[i] = Convert.ToDouble(Current.Customer.Meals.Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(x => x.MealCalorie));

                var meals = CrudProcess.GetAll<Meal>().Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).ToList();
                var customerMeals = meals.GroupBy(m => m.CustomerId).Select(g => new
                {
                    CustomerId = g.Key,
                    TotalCalories = g.Sum(m => m.MealCalorie)
                }).ToList();

                avgCalories[i] = Convert.ToDouble(customerMeals.Average(cmeal => cmeal.TotalCalories));
            }
        }

        private void KategoriSeçiliOgünNull()
        {
            for (int i = 0; i < 7; i++)
            {

                var mealDetails = CrudProcess.GetAll<MealDetail>();

                userCalories[i] = Convert.ToDouble(mealDetails.Where(md => md.Food.Category == category && md.Meal.Customer == Current.Customer && md.Meal.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(md => md.Meal.MealCalorie));


                var meals = mealDetails.Where(md => md.Food.Category == category && md.Meal.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).ToList();

                var customerMeals = meals.GroupBy(m => m.Meal.CustomerId).Select(g => new
                {
                    CustomerId = g.Key,
                    TotalKcal = g.Sum(md => md.Meal.MealCalorie)
                });

                avgCalories[i] = Convert.ToDouble(customerMeals.Average(m => m.TotalKcal));
            }
        }

        private void FindMeals()
        {
            
            if (rbAll.Checked) // meal için hepsi seçerse
            {
                meal = null;
            }
            else // meal seçerse
            {
                if (rbBreakFast.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Breakfast).ToList();
                }
                else if (rbDinner.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Dinner).ToList();
                }
                else if (rbLaunch.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Lunch).ToList();
                }
                else if (rbExtra.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Extra).ToList();
                }

            }
        }

 

        private void FindCategoryOrCategories()
        {
            _categories.Clear();
            category = null;
            if (cbCategory.SelectedIndex == 0 || cbCategory.SelectedIndex == -1)
            {
                _categories = CrudProcess.GetAll<Category>(); // tüm kategoriler
            }
            else
            {
                category = CrudProcess.GetByID<Category>(cbCategory.SelectedIndex); // sadece seçilen kategori
            }
        }
        private void DrawGraph()
        {
            for (int i = 0; i < userCalories.Length; i++)
            {
                userSeries.Points.Add(new DataPoint(i , userCalories[i]));
                avgSeries.Points.Add(new DataPoint(i , avgCalories[i]));
            }

            plotModel.Series.Add(userSeries);
            plotModel.Series.Add(avgSeries);

            var xAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            xAxis.Labels.AddRange(new[] { "1. gün", "2. gün", "3. gün", "4. gün", "5. gün", "6. gün", "7. gün" });

            plotModel.Axes.Add(xAxis);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Kalori" };
            plotModel.Axes.Add(yAxis);
            plistWeeklyGraph.Model = plotModel;
            xAxis.StartPosition = 1;
            xAxis.EndPosition = 0;
        }
        private void SetGraphTittle()
        {
            plotModel = new PlotModel { Title = "Kullanıcı Kalori Miktarı" };
            userSeries = new LineSeries { Title = "Kullanıcı", MarkerType = MarkerType.Circle };
            avgSeries = new LineSeries { Title = "Ortalama", MarkerType = MarkerType.Circle };
        }
    }
}
