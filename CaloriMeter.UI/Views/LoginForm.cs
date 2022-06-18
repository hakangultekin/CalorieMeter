using CaloriMeter.BLL.Services;
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

namespace CaloriMeter.UI.Views
{
    public partial class LoginForm : Form
    {
        UserService userService;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForms.UserRegistiration userRegistiration = new UserForms.UserRegistiration();
            userRegistiration.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            User user = new User();
            string userName = txtKullaniciAd.Text;
            string password = txtParola.Text;

            userService = new UserService();

            try
            {
                if (user != null)
                {
                    if (!user.State)
                    {
                        MessageBox.Show("Admin bu kullanıcıyı onaylamamış");
                        return;
                    }
                    switch (user.UserType)
                    {
                        case UserType.Admin:
                            AdminForms.AdminLogin adminLogin = new AdminForms.AdminLogin();
                            this.Hide();
                            adminLogin.ShowDialog();
                            this.Show();
                            break;
                        case UserType.Standard:
                            UserForms.UserLogin userLogin = new UserForms.UserLogin();
                            this.Hide();
                            userLogin.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz. Eğer üye değilseniz kayıt olunuz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
