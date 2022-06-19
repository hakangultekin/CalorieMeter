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
    public partial class UpdateInfo : Form
    {
        User user;
        UserService userService;
        ActivityTypeService activityTypeService;
        public UpdateInfo(User _user)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            user = _user;
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

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            activityTypeService = new ActivityTypeService();
            userService = new UserService();
            FillActivities();
            FillGender();
            FillUserInfo();
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                userService = new UserService();

                user = userService.GetUserById(user.UserID);
                user.UserName = txtEmail.Text;
                user.Name = txtAd.Text;
                user.LastName = txtSoyad.Text;
                user.Gender = (Gender)cbCinsiyet.SelectedItem;
                user.BirthDate = dtpDogum.Value;
                user.Height = (int)nudBoy.Value;
                user.Weight = (int)nudKilo.Value;
                user.KiloGoal = (int)nud_hedefKilo.Value;
                user.UserType = UserType.Standard;
                user.ActivityTypeID = (int)cbAktivite.SelectedValue;

                bool updateUser = userService.Update(user);
                if (updateUser) MessageBox.Show("Kullanıcı bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void FillActivities()
        {
            activityTypeService = new ActivityTypeService();
            cbAktivite.DataSource = activityTypeService.GetActivities();
            cbAktivite.DisplayMember = "ActivityName";
            cbAktivite.ValueMember = "ActivityTypeID";

            cbAktivite.SelectedIndex = 0;
        }

        void FillGender()
        {
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cbCinsiyet.Items.Add(item);
            }
        }

        void FillUserInfo()
        {
            user = userService.GetUserById(user.UserID);
            txtAd.Text = user.Name;
            txtSoyad.Text = user.LastName;
            txtEmail.Text = user.UserName;
            cbCinsiyet.Text = user.Gender.ToString();
            cbAktivite.SelectedValue = user.ActivityTypeID;
            dtpDogum.Value = user.BirthDate;
            nudBoy.Value = user.Height;
            nudKilo.Value = user.Weight;
            nud_hedefKilo.Value = (int)user.KiloGoal;
        }

        private void btn_parolaDegistir_Click(object sender, EventArgs e)
        {
            if (user.Password != txt_eskiParola.Text)
            {
                MessageBox.Show("Eski parolanız doğru değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CheckPasswords())
            {
                MessageBox.Show("Girdiğiniz parolalar uyuşmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                user = userService.GetUserById(user.UserID);
                user.Password = txt_yeniParola.Text;

                bool updateUser = userService.Update(user);
                if (updateUser) MessageBox.Show("Şifre güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        bool CheckPasswords()
        {
            if (txt_yeniParola.Text != txt_yeniParolaTekrar.Text) return false;
            else return true;
        }

        private void btnAktivityInfo_Click(object sender, EventArgs e)
        {
            string aciklama = "Aktivite Yok : Gün içinde fiziksel aktivitesi minimum düzeyde olan kişiler. Örneğin; masabaşı iş, araba sürmek vb.\n\n" +
                "Az Aktif : Gün içinde zaman zaman ayakta durmayı gerektiren bir işte çalışan ya da çok az derecede hafif egzersiz yapan kişiler.\n\n" +
                "Aktif : Gün içerisinde işi gereği sürekli ayakta çalışan, fiziksel olarak emek harcayan ya da düzenli egzersiz yapan kişiler.\n\n" +
                "Çok Aktif : Düzenli olarak ağır egzersizler yapan ya da tamamen fiziki güce dayalı bir işte çalışan kişiler. Örneğin; inşaat işçisi, profesyonel sporcu vb.\n\n\n";
            MessageBox.Show(aciklama, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
