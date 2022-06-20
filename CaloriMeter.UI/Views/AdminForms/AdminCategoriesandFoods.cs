using CaloriMeter.BLL.Services;
using CaloriMeter.DAL;
using CaloriMeter.Model.Entitites;
using CaloriMeter.Model.Enums;
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
    public partial class AdminCategoriesandFoods : Form
    {
        CalorieMeterDbContext context;
        FoodService foodService;
        CategoryService categoryService;
        Food food;

        public AdminCategoriesandFoods()
        {
            InitializeComponent();

            context = new CalorieMeterDbContext();
            categoryService = new CategoryService();
            foodService = new FoodService();

            FillComboBoxWithCategory();
        }

        private void AdminCategoriesandFoods_Load(object sender, EventArgs e)
        {
            GetAllFoodWithCategoyName();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foodService = new FoodService();
            food = new Food()
            {
                CategoryID = (int)cbCategories.SelectedValue,
                Name = txtYemekler.Text,
                Per100Cal = Convert.ToInt32(txtKalori.Text),
                Grams = Convert.ToInt32(txtGram.Text),
                UserID = 1
            };

            bool newFood = foodService.Insert(food);
            if (newFood) MessageBox.Show("Yeni yiyecek başarı ile eklendi.");
            context.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            List<Food> foodList = foodService.GetAll();
            foreach (Food item in foodList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Category.Name;
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Per100Cal.ToString());
                lvi.SubItems.Add(item.PortionSize.ToString());
                lvi.Tag = item;

                lvListe.Items.Add(lvi);
            }

            Food food = foodService.FindFood(txtYemekler.Text).SingleOrDefault();


            food.Name = txtYemekler.Text;
            food.CategoryID = cbCategories.SelectedIndex;
            food.Per100Cal = Convert.ToInt32(txtKalori.Text);
            food.Grams = Convert.ToInt32(txtGram.Text);


            bool updateFood = foodService.Update(food);
            if (updateFood) MessageBox.Show("Yeni kategori başarı ile eklendi.");
            context.SaveChanges();
        }

        private void lvListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListe.SelectedItems.Count > 0)
            {
                cbCategories.Text = lvListe.SelectedItems[0].SubItems[0].Text;
                txtYemekler.Text = lvListe.SelectedItems[0].SubItems[1].Text;
                txtKalori.Text = lvListe.SelectedItems[0].SubItems[2].Text;
                txtGram.Text = lvListe.SelectedItems[0].SubItems[3].Text;
            }
        }

        void GetAllFoodWithCategoyName()
        {
            List<Food> foodList = foodService.GetAll();

            foreach (Food item in foodList)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Category.Name;
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Per100Cal.ToString());
                lvi.SubItems.Add(item.PortionSize.ToString());
                lvi.Tag = item;

                lvListe.Items.Add(lvi);
            }
        }

        void FillComboBoxWithCategory()
        {
            cbCategories.DataSource = categoryService.GetAll();
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DisplayMember = "Name";
            cbCategories.SelectedIndex = -1;
        }

    }
}
