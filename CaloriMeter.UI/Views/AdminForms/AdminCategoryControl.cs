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
        CategoryService categoryService;
        Category duzenlenenCat;
        public AdminCategoryControl()
        {
            categoryService = new CategoryService();
            InitializeComponent();
            FillCategories();
        }

        void FillCategories()
        {
            cbCats.ValueMember = "CategoryID";
            cbCats.DisplayMember = "Name";
            cbCats.DataSource = categoryService.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = new Category()
                {
                    Name = txt_newCatName.Text
                };

                bool newCat = categoryService.Insert(cat);
                if (newCat) MessageBox.Show("Yeni kategori başarı ile eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCatGuncelle_Click(object sender, EventArgs e)
        {
            if (duzenlenenCat != null)
            {
                try
                {
                    duzenlenenCat.Name = txt_catguncelName.Text;
                    bool updateCat = categoryService.Update(duzenlenenCat);

                    if (updateCat) MessageBox.Show("Kategori bilgisi güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_catguncelName.Text = cbCats.Text;
            if(cbCats.SelectedIndex > -1)
                duzenlenenCat = categoryService.GetCategoryById((int)cbCats.SelectedValue);
        }
    }
}
