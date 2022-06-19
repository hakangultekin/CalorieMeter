using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriMeter.UI.Views.UserForms
{
    public partial class MyMeals : Form
    {
        MealService mealService;
        int userid;
        public MyMeals(int _userid)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            userid = _userid;
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 145, 124), Color.FromArgb(165, 240, 197), 90f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void MyMeals_Load(object sender, EventArgs e)
        {
            FillMeals();
        }

        void FillMeals()
        {
            mealService = new MealService();
            List<Meal> meals = mealService.GetUserMeals(userid);

            if (meals.Count > 0)
            {
                lst_meals.Items.Clear();
                foreach (Meal item in meals)
                {
                    ListViewItem lvi = new ListViewItem(item.RegisterationDate.ToShortTimeString());
                    lvi.SubItems.Add(item.MealType.MealTypeName);
                    lvi.SubItems.Add(item.MealDetails.Sum(x => x.Calory).ToString());
                    lvi.SubItems.Add(item.MealDetails.Count.ToString());
                    lvi.Tag = item;
                    lst_meals.Items.Add(lvi);
                }
            }
        }
    }
}
