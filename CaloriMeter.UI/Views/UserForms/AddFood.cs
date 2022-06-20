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
    public partial class AddFood : Form
    {
        CategoryService categoryService;
        FoodService foodService;
        int userid;
        public AddFood(int _userid)
        {
            InitializeComponent();
            userid = _userid;
            categoryService = new CategoryService();
            FillCategories();
        }

        void FillCategories()
        {
            cb_kategoriler.ValueMember = "CategoryID";
            cb_kategoriler.DisplayMember = "Name";
            cb_kategoriler.DataSource = categoryService.GetAll();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                foodService = new FoodService();
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
    }
}
