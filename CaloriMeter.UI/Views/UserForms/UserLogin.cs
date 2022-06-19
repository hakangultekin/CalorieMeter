using CaloriMeter.BLL.Services;
using CaloriMeter.Model.Entitites;
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
    public partial class UserLogin : Form
    {
        User user;
        UserService userService;
        MealService mealService;
        UpdateInfo ui;
        MyMeals myMeals;
        Statistics stats;
        public UserLogin()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
        }
        public UserLogin(User _user)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            user = _user;
        }

        private void BilgileriGetir()
        {
            userService = new UserService();
            mealService = new MealService();
            user = userService.GetUserById(user.UserID);

            lbl_personName.Text = $"Hoşgeldiniz {user.Name} {user.LastName}";
            lblMevcutKilo.Text = user.Weight.ToString() + " kg";
            lblMevcutKilo2.Text = user.Weight.ToString() + " kg";
            llblHedefKilo.Text = user.KiloGoal.ToString() + " kg";
            lbl_boy.Text = user.Height + " cm";

            pb_hedefKilo.Maximum = Convert.ToInt32(user.Weight);
            pb_hedefKilo.Value = Convert.ToInt32(user.KiloGoal);

            double vki = VucutKitleEndeksiHesapla(user);
            lblEndeks.Text = vki.ToString("N");
            lbl_endeksDurum.Text = EndeksDurumVer(vki);
            lbl_gunlukKalori.Text = GunlukKaloriHesapla(user).ToString();

            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            List<Meal> bugununOgunleri = mealService.GetUserMeals(user.UserID, today, today.AddDays(1));
            int gunlukTuketilenKalori = bugununOgunleri.Sum(a => a.MealDetails.Sum(b => b.Calory));
            int gunlukStandartKalori = Convert.ToInt32(GunlukKaloriHesapla(user));

            if (user.Weight > user.KiloGoal)
                lbl_kalanBilgiText.Text = "Günlük Kalan Kalori";
            else
                lbl_kalanBilgiText.Text = "Hedef Kalori";

            if (gunlukTuketilenKalori > gunlukStandartKalori)
            {
                pb_kalanKalori.Value = 100;
                lbl_harcanacakKalori.Text = "0 kcal";
            }
            else
            {
                pb_kalanKalori.Maximum = gunlukStandartKalori;
                pb_kalanKalori.Value = gunlukTuketilenKalori;
                lbl_harcanacakKalori.Text = (gunlukStandartKalori - gunlukTuketilenKalori).ToString();
            }

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

        private string MotivasyonVer()
        {
            string[] sozler = 
                {
                    "Daha fazla kaydet, daha fazla öğren !",
                    "Seni görmek çok iyi !",
                    "Selam, tekrar hoşgeldiniz !",
                    "Bugün iyi bir gün olacak !",
                    "Bugün seni alkışlıyoruz !",
                    "Menüde motivasyon var !",
                    "Her adım ileriye doğru bir adımdır.",
                    "Kaydetmek, daha akıllı seçimlere yol açar.",
                    "Günü birlik yaşayarak, oraya varacaksın.",
                    "Günü güzel geçirmeye hazır mısın ?"
                };

            Random random = new Random();

            return sozler[random.Next(0, sozler.Length-1)];
        }

        private double VucutKitleEndeksiHesapla(User user)
        {
            return (double)user.Weight / (user.Height/100.0 * user.Height/100.0);
        }

        private string EndeksDurumVer(double vki)
        {
            if (vki < 18.5) return "İdeal kilonun altında";
            else if (vki >= 18.5 && vki < 24.9) return "İdeal kiloda";
            else if (vki >= 25 && vki < 29.9) return "İdeal kilonun üstünde";
            else if (vki >= 30 && vki < 39.9) return "İdeal kilonun çok üstünde (Obez)";
            else return "İdeal kilonun çok üstünde (Morbid Obez)";
        }

        private double GunlukKaloriHesapla(User user)
        {
            double cal = 0;
            switch (user.Gender)
            {
                case Model.Enums.Gender.Erkek:
                    cal = (10 * user.Weight) + (6.25 * user.Height) - (5 * user.Age) + 5;
                    break;
                case Model.Enums.Gender.Kadın:
                    cal = (10 * user.Weight) + (6.25 * user.Height) - (5 * user.Age) - 161;
                    break;
            }

            switch (user.ActivityTypeID)
            {
                case 1:
                    cal = cal * 1.2;
                    break;
                case 2:
                    cal = cal * 1.375;
                    break;
                case 3:
                    cal = cal * 1.55;
                    break;
                case 4:
                    cal = cal * 1.725;
                    break;
            }

            return cal;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txt_hosgeldinMesaj.Text = MotivasyonVer();
            BilgileriGetir();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        public void ShowMainForm()
        {
            this.Show();
        }

        public void btn_bilgiGuncelle_click(object sender, EventArgs e)
        {
            if (ui == null) ui = new UpdateInfo(user);
            this.Hide();
            ui.ShowDialog();
            this.Show();
        }

        private void btn_ogunEkle_Click(object sender, EventArgs e)
        {
            if (myMeals == null) myMeals = new MyMeals(user.UserID);
            this.Hide();
            myMeals.ShowDialog();
            this.Show();
        }

        private void btn_istatistikler_Click(object sender, EventArgs e)
        {
            if (stats == null) stats = new Statistics(user.UserID);
            this.Hide();
            stats.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
