using CaloriMeter.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriMeter.UI.Views.AdminForms
{
    public partial class AdminStatistics : Form
    {
        CalorieMeterDbContext context;
        public AdminStatistics()
        {
            InitializeComponent();
            context = new CalorieMeterDbContext();
        }

        private void AdminStatistics_Load(object sender, EventArgs e)
        {
            //var en = context.MealDetails.GroupBy(m => m.FoodID).Select(group => new { FoodId = group.Key, sum = group.Sum(item => item.FoodID) }).OrderByDescending(a => a.sum).FirstOrDefault().ToString(); 
            
        }
    }
}
