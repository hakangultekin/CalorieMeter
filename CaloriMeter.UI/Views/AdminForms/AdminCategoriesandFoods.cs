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

            cbCategories.DataSource = categoryService.GetAll();
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DisplayMember = "Name";          
            cbCategories.SelectedIndex = 0;
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
            foreach (var item in context.Foods.Join(context.Categories, f => f.CategoryID, c => c.CategoryID, (f, c) => new { c.Name, FoodName = f.Name, f.Per100Cal, f.PortionSize }))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (string)cbCategories.SelectedItem;
                lvi.SubItems.Add(txtYemekler.Text);
                lvi.SubItems.Add(item.Per100Cal.ToString());
                lvi.SubItems.Add(item.PortionSize.ToString());

                lvListe.Items.Add(lvi);
            }
        }

        void GetAllFoodWithCategoyName()
        {
            foreach (var item in context.Foods.Join(context.Categories, f => f.CategoryID, c => c.CategoryID, (f, c) => new { c.Name, FoodName = f.Name, f.Per100Cal, f.PortionSize }))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.FoodName);
                lvi.SubItems.Add(item.Per100Cal.ToString());
                lvi.SubItems.Add(item.PortionSize.ToString());

                lvListe.Items.Add(lvi);
            }
        }
    }
}
