using CaloriMeter.BLL.Services;
using CaloriMeter.DAL;
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

namespace CaloriMeter.UI.Views.AdminForms
{
    public partial class AdminCategoryControl : Form
    {
        CalorieMeterDbContext context;
        CategoryService categoryService;
        public AdminCategoryControl()
        {
            InitializeComponent();


            context = new CalorieMeterDbContext();
            categoryService = new CategoryService();

            cbCats.DataSource = categoryService.GetAll();
            cbCats.ValueMember = "CategoryID";
            cbCats.DisplayMember = "Name";
            cbCats.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category cat = new Category()
            {
                Name = txtYeniCat.Text
            };

            bool newCat = categoryService.Insert(cat);
            if (newCat) MessageBox.Show("Yeni kategori başarı ile eklendi.");
            context.SaveChanges();
        }

        private void btnCatGuncelle_Click(object sender, EventArgs e)
        {
            if (cbCats.SelectedIndex == -1) txtYeniCat.Text = string.Empty;
            //else cbCats.Text = txtYeniCat.Text;

            Category category = new Category()
            {
                CategoryID = cbCats.SelectedIndex,
                Name = txtYeniCat.Text
            };

            bool updateCat = categoryService.Update(category);
            if (updateCat) MessageBox.Show("Yeni kategori başarı ile eklendi.");
            context.SaveChanges();
        }

        private void cbCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCats.Text = txtYeniCat.Text;
        }
    }
}
