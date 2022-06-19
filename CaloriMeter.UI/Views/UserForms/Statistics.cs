using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriMeter.UI.Views.UserForms
{
    public partial class Statistics : Form
    {
        int userid;
        UserService userService;
        MealService mealService;
        CategoryService categoryService;
        MealTypeService mealTypeService; 
        
        public Statistics(int _userid)
        {
            InitializeComponent();
            userid = _userid;
            userService = new UserService();
            mealService = new MealService();
            categoryService = new CategoryService();
            mealTypeService = new MealTypeService();
            Get7DayAverageCalories();
            Get1MonthAverageCalories();
            GetByCategoriesCal();
        }

        private void Get7DayAverageCalories()
        {
            DateTime bitis = DateTime.Now;
            DateTime baslangic = bitis.AddDays(-7);

            List<Meal> allMeals = mealService.GetUserMeals(userid,baslangic, bitis);

            double kahvalti = allMeals.Where(x => x.MealTypeID == 1).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double ogleYemegi = allMeals.Where(x => x.MealTypeID == 2).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double aksamYemegi = allMeals.Where(x => x.MealTypeID == 3).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double araOgun = allMeals.Where(x => x.MealTypeID == 4).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));

            lbl_kahvaltiToplam.Text = kahvalti.ToString() + " kcal";
            lbl_ogleYemegiToplam.Text = ogleYemegi.ToString() + " kcal";
            lbl_aksamYemegiToplam.Text = aksamYemegi.ToString() + " kcal";
            lbl_araOgunToplam.Text = araOgun.ToString() + " kcal";
        }

        private void Get1MonthAverageCalories()
        {
            DateTime bitis = DateTime.Now;
            DateTime baslangic = bitis.AddMonths(-1);

            List<Meal> allMeals = mealService.GetUserMeals(userid, baslangic, bitis);

            double kahvalti = allMeals.Where(x => x.MealTypeID == 1).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double ogleYemegi = allMeals.Where(x => x.MealTypeID == 2).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double aksamYemegi = allMeals.Where(x => x.MealTypeID == 3).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double araOgun = allMeals.Where(x => x.MealTypeID == 4).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));

            lbl_kahvaltiAylik.Text = kahvalti.ToString() + " kcal";
            lbl_oglenAylik.Text = ogleYemegi.ToString() + " kcal";
            lbl_aksamAylik.Text = aksamYemegi.ToString() + " kcal";
            lbl_araOgunAylik.Text = araOgun.ToString() + " kcal";
        }

        private void GetByCategoriesCal()
        {
            List<Category> categories = categoryService.GetAll();
            List<Meal> allMeals = mealService.GetUserMeals(userid);

            foreach (Category item in categories)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());

                lst_kategoriDetay.Items.Add(lvi);
            }

        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        Food secilenFood;
        private void btn_yemekBul_Click(object sender, EventArgs e)
        {
            MealSearch ms = new MealSearch(userid);
            ms.ShowDialog();
            secilenFood = ms.selectedFood;

            txt_secilenYemek.Text = secilenFood.Name;

            List<Meal> allMeals = mealService.GetUserMeals(userid);
            List<MealType> mealTypes = mealTypeService.GetAllTypes();

            
            int kahvaltiAdet = allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Count;
            int kahvaltiKalori = allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
            lbl_ybrKA.Text = kahvaltiAdet.ToString();
            lbl_ybrKK.Text = kahvaltiKalori.ToString();

            int oglenAdet = allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Count;
            int oglenKalori = allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
            lbl_ybrOA.Text = oglenAdet.ToString();
            lbl_ybrOK.Text = oglenKalori.ToString();

            int aksamAdet = allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Count;
            int aksamKalori = allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
            lbl_ybrAA.Text = aksamAdet.ToString();
            lbl_ybrAK.Text = aksamKalori.ToString();

            int araAdet = allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Count;
            int araKalori = allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.Food.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
            lbl_ybrARA.Text = araAdet.ToString();
            lbl_ybrARK.Text = araKalori.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
