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
    public partial class MealSearch : Form
    {
        FoodService foodService;
        CategoryService categoryService;
        public Food selectedFood;
        int userid;

        public MealSearch(int _userid)
        {
            InitializeComponent();
            userid = _userid;
            foodService = new FoodService();
        }

        private void MealSearch_Load(object sender, EventArgs e)
        {
            FillCategories();
            FillList(foodService.GetAllByUser(userid));
        }

        void FillList(List<Food> foodList)
        {
            listView1.Items.Clear();
            foreach (Food item in foodList)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Per100Cal.ToString());
                lvi.SubItems.Add(item.Grams.ToString());
                lvi.SubItems.Add(item.Category.Name);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        void FillCategories()
        {
            categoryService = new CategoryService();
            List<Category> categories = categoryService.GetAll();
            categories.Insert(0, new Category { CategoryID = -1, Name = "-- Tümü --" });

            cmb_kategoriler.ValueMember = "CategoryID";
            cmb_kategoriler.DisplayMember = "Name";
            cmb_kategoriler.DataSource = categories;
        }

        private void cmb_kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_yemekAdi.Clear();

            if (cmb_kategoriler.SelectedIndex != 0)
            {
                FillList(foodService.GetAllByUser(userid).Where(x => x.CategoryID == (int)cmb_kategoriler.SelectedValue).ToList());
            }
                
            else
                FillList(foodService.GetAllByUser(userid));
        }

        private void txt_yemekAdi_TextChanged(object sender, EventArgs e)
        {
            if (txt_yemekAdi.Text.Length > 2 && !string.IsNullOrWhiteSpace(txt_yemekAdi.Text))
            {
                if (cmb_kategoriler.SelectedIndex != 0)
                    FillList(foodService.FindFoodByUser(userid, txt_yemekAdi.Text).Where(x => x.CategoryID == (int)cmb_kategoriler.SelectedValue).ToList());
                else
                    FillList(foodService.FindFoodByUser(userid, txt_yemekAdi.Text));
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Index > -1)
            {
                selectedFood = (Food)listView1.SelectedItems[0].Tag;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            FillList(foodService.GetAllByUser(userid));
        }
    }
}
