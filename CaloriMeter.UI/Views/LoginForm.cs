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
using System.Drawing.Drawing2D;
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
            //this.Paint += new PaintEventHandler(set_background);
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 145, 124), Color.FromArgb(165, 240, 197), 90f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
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
            if (string.IsNullOrWhiteSpace(txtKullaniciAd.Text) || string.IsNullOrWhiteSpace(txtParola.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                        MessageBox.Show("Lütfen admin onayını bekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    switch (user.UserType)
                    {
                        case UserType.Admin:
                            AdminLogin adminLogin = new AdminLogin(user);
                            this.Hide();
                            adminLogin.ShowDialog();
                            this.Show();
                            break;
                        case UserType.Standard:
                            UserLogin userLogin = new UserLogin(user);
                            this.Hide();
                            userLogin.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz. Eğer üye değilseniz kayıt olunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
