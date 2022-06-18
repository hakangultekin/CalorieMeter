using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
using CaloriMeter.Model.Enums;
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

namespace CaloriMeter.UI.Views.UserForms
{
    public partial class UserRegistiration : Form
    {
        UserService userService;
        ActivityTypeService activityTypeService;
        User user;
        //Gender gender = new Gender();

        public UserRegistiration()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cbCinsiyet.Items.Add(item);
            }
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
            this.Text = "Bilgi Güncelle";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                userService = new UserService();
                CheckPasswords();

                user = new User();
                user.UserName = txtEmail.Text;
                user.Name = txtAd.Text;
                user.LastName = txtSoyad.Text;
                user.Password = txtParola.Text;
                user.Gender = (Gender)cbCinsiyet.SelectedItem;
                user.BirthDate = dtpDogum.Value;
                user.Height = (int)nudBoy.Value;
                user.Weight = (int)nudKilo.Value;
                user.UserType = UserType.Standard;
                user.ActivityTypeID = (int)cbAktivite.SelectedValue;

                bool updateUser = userService.Insert(user);
                if (updateUser) MessageBox.Show("Kayıt talebiniz alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CheckPasswords()
        {
            if (txtParola.Text != txtParolaTekrar.Text) throw new Exception("Girdiğiniz parolalar uyuşmuyor.");
        }

        void FillActivities()
        {
            activityTypeService = new ActivityTypeService();
            cbAktivite.DataSource = activityTypeService.GetActivities();
            cbAktivite.DisplayMember = "ActivityName";
            cbAktivite.ValueMember = "ActivityTypeID";

            cbAktivite.SelectedIndex = 0;
        }

        private void UserRegistiration_Load(object sender, EventArgs e)
        {
            dtpDogum.MaxDate = DateTime.Now;
            dtpDogum.MinDate = new DateTime(1900,01,01);
            cbCinsiyet.SelectedIndex = 0;
            FillActivities();
        }
        private void btnAktivityInfo_Click(object sender, EventArgs e)
        {
            string aciklama = "Aktivite Yok : Gün içinde fiziksel aktivitesi minimum düzeyde olan kişiler. Örneğin; masabaşı iş, araba sürmek vb.\n\n" +
                "Az Aktif : Gün içinde zaman zaman ayakta durmayı gerektiren bir işte çalışan ya da çok az derecede hafif egzersiz yapan kişiler.\n\n" +
                "Aktif : Gün içerisinde işi gereği sürekli ayakta çalışan, fiziksel olarak emek harcayan ya da düzenli egzersiz yapan kişiler.\n\n" +
                "Çok Aktif : Düzenli olarak ağır egzersizler yapan ya da tamamen fiziki güce dayalı bir işte çalışan kişiler. Örneğin; inşaat işçisi, profesyonel sporcu vb.\n\n\n";
            MessageBox.Show(aciklama, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
