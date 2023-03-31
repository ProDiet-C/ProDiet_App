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
using WFA_ProDiet.MODELS.Models;

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
            dgvFoods.DataSource = CrudProcess.GetAll<Customer>();
        }
    }
}
