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

namespace WFA_ProDiet.UI
{
    public partial class UcWeeklyReport : UserControl
    {
        public UcWeeklyReport()
        {
            InitializeComponent();
        }


        DateTime today = DateTime.Now;
        double[] userCalories = new double[7];
        double[] avgCalories = new double[7];
        List<Customer> customers = CrudProcess.GetAll<Customer>();
        private void btnCompareByCalorie_Click(object sender, EventArgs e)
        {
            DrawAndShowGraph();
        }

        private void DrawAndShowGraph()
        {
            var plotModel = new PlotModel { Title = "Kullanıcı Kalori Miktarı" };
            var userSeries = new LineSeries { Title = "Kullanıcı", MarkerType = MarkerType.Circle };
            var avgSeries = new LineSeries { Title = "Ortalama", MarkerType = MarkerType.Circle };

            for (int i = 6; i > 0; i--)
            {
                userCalories[i] = Convert.ToDouble(Current.Customer.Meals.Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(x => x.MealCalorie));

                var meals = CrudProcess.GetAll<Meal>().Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).ToList();

                var customerMeals = meals.GroupBy(m => m.CustomerId).Select(g => new
                {
                    
                    CustomerId = g.Key,
                    TotalCalories = g.Sum(m => m.MealCalorie)

                }).ToList();
                avgCalories[i] = Convert.ToDouble(customerMeals.Average(cmeal=>cmeal.TotalCalories));
            }

            for (int i = 0; i < userCalories.Length; i++)
            {
                userSeries.Points.Add(new DataPoint(i + 1, userCalories[i]));
                avgSeries.Points.Add(new DataPoint(i + 1, avgCalories[i]));
            }

            plotModel.Series.Add(userSeries);
            plotModel.Series.Add(avgSeries);

            var xAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            xAxis.Labels.AddRange(new[] { "1. gün", "2. gün", "3. gün", "4. gün", "5. gün", "6. gün", "7. gün" });

            plotModel.Axes.Add(xAxis);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Kalori" };
            plotModel.Axes.Add(yAxis);

            plistWeeklyGraph.Model = plotModel;
        }
    }
}
