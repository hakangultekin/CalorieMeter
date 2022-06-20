using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
using CaloriMeter.UI.Views.UserForms;
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
    public partial class FoodControlPanel : Form
    {
        CategoryService categoryService;
        FoodService foodService;
        int userid;
        Food duzenlenenFood;
        public FoodControlPanel(int _userid)
        {
            InitializeComponent();
            userid = _userid;
            categoryService = new CategoryService();
            foodService = new FoodService();
            FillCategories();
        }

        void FillCategories()
        {
            cb_kategoriler.ValueMember = "CategoryID";
            cb_kategoriler.DisplayMember = "Name";
            cb_kategoriler.DataSource = categoryService.GetAll();
        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food()
                {
                    UserID = userid,
                    CategoryID = (int)cb_kategoriler.SelectedValue,
                    Name = txt_name.Text,
                    Per100Cal = (int)nud_calPer100.Value,
                    Grams = (int)nud_portionSize.Value
                };

                foodService.Insert(food);
                MessageBox.Show("Yiyecek/içecek eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            cb_kategoriler.SelectedIndex = 0;
            txt_name.Clear();
            nud_calPer100.Value = nud_calPer100.Minimum;
            nud_portionSize.Value = nud_portionSize.Minimum;
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            MealSearch ms = new MealSearch(userid, true);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                duzenlenenFood = ms.selectedFood;
                SecilenDoldur();
                btn_guncelle.Enabled = true;
                btn_ekle.Enabled = false;
                btn_sil.Enabled = true;
            }
        }

        private void SecilenDoldur()
        {
            if (duzenlenenFood != null)
            {
                txt_name.Text = duzenlenenFood.Name;
                nud_calPer100.Value = duzenlenenFood.Per100Cal;
                nud_portionSize.Value = duzenlenenFood.Grams;
                cb_kategoriler.Text = duzenlenenFood.Category.Name;
                ch_listede.Checked = duzenlenenFood.State;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (duzenlenenFood != null)
            {
                try
                {
                    Food food = foodService.FindFoodByID(duzenlenenFood.FoodID);
                    food.Name = txt_name.Text;
                    food.Per100Cal = Convert.ToInt32(nud_calPer100.Value);
                    food.Grams = Convert.ToInt32(nud_portionSize.Value);
                    food.CategoryID = (int)cb_kategoriler.SelectedValue;
                    food.State = ch_listede.Checked;

                    foodService.Update(food);
                    MessageBox.Show("Yemek güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_guncelle.Enabled = false;
                    btn_ekle.Enabled = true;
                    btn_sil.Enabled = false;

                    ClearForm();
                    duzenlenenFood = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (duzenlenenFood != null)
            {
                Food food = foodService.FindFoodByID(duzenlenenFood.FoodID);
                foodService.DelistFood(food.FoodID);
                MessageBox.Show("Yemek listeden kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_guncelle.Enabled = false;
                btn_ekle.Enabled = true;
                btn_sil.Enabled = false;
                ClearForm();
            }
        }
    }
}
