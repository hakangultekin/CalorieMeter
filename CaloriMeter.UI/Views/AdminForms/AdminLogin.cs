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
            FoodControlPanel fcp = new FoodControlPanel(user.UserID);
            FormHideAndShow(fcp);
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin istatistik paneli bakım aşamasındadır...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //AdminStatistics adminStatistics = new AdminStatistics();
            //FormHideAndShow(adminStatistics);
        }

        private void btnkategoriEkle_Click(object sender, EventArgs e)
        {
            AdminCategoryControl adminCategoryControl = new AdminCategoryControl();
            FormHideAndShow(adminCategoryControl);
        }

        public Form FormHideAndShow(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
            return form;
        }

     
    }
}
