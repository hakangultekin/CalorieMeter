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
        Food food;


        public AdminCategoriesandFoods()
        {
            context = new CalorieMeterDbContext();
            food = new Food();

            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(PortionSize)))
            {
                cbPorsTip.Items.Add(item);
            }
        }

        private void AdminCategoriesandFoods_Load(object sender, EventArgs e)
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //food = new Food();
            //{
            //    txtKategoriler.Text = category.Name;
            //    txtYemekler.Text = food.Name;
            //    txtKalori.Text = food.Per100Cal.ToString();
            //    txtPorsTip.Text = txtPorsTip.Text.ToString();
            //    user.Name = "admin";


            //}
           

        }
    }
}
