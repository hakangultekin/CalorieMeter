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
            mealService = new MealService();
            List<Meal> meals = mealService.GetUserMeals(userid);
            FillMeals(meals);
            dtp_baslangic.Value = DateTime.Today;
            dtp_bitis.Value = DateTime.Today;
        }

        void FillMeals(List<Meal> meals)
        {
            lst_meals.Items.Clear();
            if (meals.Count > 0)
            {
                foreach (Meal item in meals)
                {
                    ListViewItem lvi = new ListViewItem(item.RegisterationDate.ToShortDateString());
                    lvi.SubItems.Add(item.MealType.MealTypeName);
                    lvi.SubItems.Add(item.MealDetails.Sum(x => x.Calory).ToString());
                    lvi.SubItems.Add(item.MealDetails.Count.ToString());
                    lvi.Tag = item;
                    lst_meals.Items.Add(lvi);
                }
            }
        }

        private void btn_ogunAra_Click(object sender, EventArgs e)
        {
            mealService = new MealService();
            try
            {
                List<Meal> meals = mealService.GetUserMeals(userid, dtp_baslangic.Value, dtp_bitis.Value.AddDays(1));
                FillMeals(meals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lst_meals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_meals.SelectedItems.Count > 0 && lst_meals.SelectedItems[0].Index > -1)
            {
                lst_ogunDetay.Items.Clear();
                Meal selectedMeal = (Meal)lst_meals.SelectedItems[0].Tag;
                foreach (MealDetail item in selectedMeal.MealDetails)
                {
                    ListViewItem lvi = new ListViewItem(selectedMeal.MealType.MealTypeName);
                    lvi.SubItems.Add(item.Food.Name);
                    lvi.SubItems.Add(item.Grams.ToString());
                    lvi.SubItems.Add(item.Calory.ToString());
                    lvi.Tag = item;
                    lst_ogunDetay.Items.Add(lvi);
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal(userid);
            addMeal.ShowDialog();
            UpdateMeals();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lst_meals.SelectedItems.Count > 0 && lst_meals.SelectedItems[0].Index > -1)
            {
                AddMeal addMeal = new AddMeal((Meal)lst_meals.SelectedItems[0].Tag);
                addMeal.ShowDialog();
                UpdateMeals();
            }
        }

        void UpdateMeals()
        {
            mealService = new MealService();
            List<Meal> meals = mealService.GetUserMeals(userid);
            FillMeals(meals);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lst_meals.SelectedItems.Count > 0 && lst_meals.SelectedItems[0].Index > -1)
            {
                Meal meal = (Meal)lst_meals.SelectedItems[0].Tag;
                mealService.Delete(meal.MealID);
                FillMeals(mealService.GetUserMeals(userid));
            }
        }

        private void MyMeals_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
