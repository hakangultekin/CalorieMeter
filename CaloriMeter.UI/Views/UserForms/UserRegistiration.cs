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

namespace CaloriMeter.UI.Views.UserForms
{
    public partial class UserRegistiration : Form
    {
        UserService userService;
        User user;
        //Gender gender = new Gender();

        public UserRegistiration()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cbCinsiyet.Items.Add(item);
            }
            //foreach (var item in Enum.GetValues(typeof(UserType)))
            //{
            //    cnUserType.Items.Add(item);
            //}
            //foreach (var item in Enum.GetValues(typeof()))
            //{
            //    cbAktivite.Items.Add(item);
            //}
            btnKayit.Text = "Kayıt Ol";

        }

        public UserRegistiration(User _user)
        {
            InitializeComponent();
            this.user = _user;
            user.UserName = txtEmail.Text;
            user.Name = txtAd.Text;
            user.LastName = txtSoyad.Text;
            user.Password = txtParola.Text;
            user.Gender = (Gender)cbCinsiyet.SelectedItem;
            user.BirthDate = dtpDogum.Value;
            user.Height = (int)nudBoy.Value;
            user.Weight = (int)nudKilo.Value;
            btnKayit.Text = "Güncelle";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            user = new User();
            user.UserName = txtEmail.Text;
            user.Name = txtAd.Text;
            user.LastName = txtSoyad.Text;
            user.Password = txtParola.Text;
            user.Gender = (Gender)cbCinsiyet.SelectedItem;
            user.BirthDate = dtpDogum.Value;
            user.Height = (int)nudBoy.Value;
            user.Weight = (int)nudKilo.Value;
            //user.ActivityTypeID = Convert.ToInt32(txtAktivite.Text);
            user.UserType = UserType.Standard;


            userService = new UserService();
            bool updateUser = userService.Insert(user);

            if (updateUser) MessageBox.Show("Kayıt talebiniz alınmıştır.");
        }

        private void cbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserRegistiration_Load(object sender, EventArgs e)
        {
            //cnUserType.SelectedIndex = 1;
            //cnUserType.Visible = false;
        }
    }
}
