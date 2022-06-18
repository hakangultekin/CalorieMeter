using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
using CaloriMeter.Model.Enums;
using CaloriMeter.UI.Views.AdminForms;
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
            UserRegistiration userRegistiration = new UserRegistiration();
            this.Hide();
            userRegistiration.ShowDialog();
            this.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtKullaniciAd.Text;
            string password = txtParola.Text;

            userService = new UserService();
            User user = userService.CheckLogin(userName, password);

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
                            AdminLogin adminLogin = new AdminLogin();
                            this.Hide();
                            adminLogin.ShowDialog();
                            this.Show();
                            break;
                        case UserType.Standard:
                            UserLogin userLogin = new UserLogin();
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
