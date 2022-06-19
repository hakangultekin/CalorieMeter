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
    public partial class AdminLogin : Form
    {
        User user;
        public AdminLogin(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        private void btnKullaniciKontrol_Click(object sender, EventArgs e)
        {
            AdminUserControl adminUserControl = new AdminUserControl();
            FormHideAndShow(adminUserControl);
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            AdminCategoriesandFoods adminCategoriesandFoods = new AdminCategoriesandFoods();
            FormHideAndShow(adminCategoriesandFoods);
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            AdminStatistics adminStatistics = new AdminStatistics();
            FormHideAndShow(adminStatistics);
        }

        public Form FormHideAndShow(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
            return form;
        }

        private void btnkategoriEkle_Click(object sender, EventArgs e)
        {
            AdminCategoryControl adminCategoryControl = new AdminCategoryControl();
            FormHideAndShow(adminCategoryControl);
        }
    }
}
