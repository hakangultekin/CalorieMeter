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
    public partial class AddMeal : Form
    {
        int userid;
        Meal myMeal;
        UserService userService;
        FoodService foodService;
        MealService mealService;
        MealTypeService mealTypeService;
        Food secilenFood;

        public AddMeal(int _userid)
        {
            InitializeComponent();
            myMeal = new Meal();
            userid = _userid;
            mealTypeService = new MealTypeService();
            mealService = new MealService();
            userService = new UserService();
            foodService = new FoodService();
            this.Paint += new PaintEventHandler(set_background);
            EditMealTypes();
        }

        public AddMeal(Meal _meal)
        {
            InitializeComponent();
            mealTypeService = new MealTypeService();
            mealService = new MealService();
            userService = new UserService();
            foodService = new FoodService();
            myMeal = mealService.GetMealByID(_meal.MealID);
            userid = myMeal.UserID;

            UrunluAcilis(myMeal);
            EditMealTypes();
            this.Paint += new PaintEventHandler(set_background);
        }

        void UrunluAcilis(Meal meal)
        {
            FillList();
        }

        void EditMealTypes()
        {
            List<MealType> list = mealTypeService.GetAllTypes();
            cb_mealTypes.ValueMember = "MealTypeID";
            cb_mealTypes.DisplayMember = "MealTypeName";
            cb_mealTypes.DataSource = list;
            cb_mealTypes.SelectedIndex = 0;
            cb_birim.SelectedIndex = 0;

            if (myMeal.MealType != null)
                cb_mealTypes.Text = myMeal.MealType.MealTypeName;
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

        private void AddMeal_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_mealTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            myMeal.MealTypeID = (int)cb_mealTypes.SelectedValue;
        }

        private void btn_yemekAra_Click(object sender, EventArgs e)
        {
            MealSearch ms = new MealSearch(userid);
            ms.ShowDialog();
            secilenFood = ms.selectedFood;
            SecilenFoodDoldur();
        }

        void SecilenFoodDoldur()
        {
            if (secilenFood != null)
            {
                txt_yemekAdi.Text = secilenFood.Name;

                if (cb_birim.SelectedIndex == 0)
                {
                    nud_gram.Value = 100;
                    txt_kalori.Text = secilenFood.Per100Cal.ToString();
                }
                else
                {
                    nud_gram.Value= secilenFood.Grams;
                    decimal kalori = (decimal)(secilenFood.Per100Cal / 100.0) * nud_gram.Value;
                    txt_kalori.Text = Convert.ToInt32(kalori).ToString();
                }
            }
        }

        private void cb_birim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenFoodDoldur();
        }

        private void nud_gram_ValueChanged(object sender, EventArgs e)
        {
            decimal kalori = (decimal)(secilenFood.Per100Cal / 100.0) * nud_gram.Value;

            if (secilenFood != null)
                txt_kalori.Text = Convert.ToInt32(kalori).ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (secilenFood != null)
            {
                Food food = foodService.FindFoodByID(secilenFood.FoodID);
                MealDetail mealDetail = new MealDetail() {FoodID = food.FoodID, Grams = Convert.ToInt32(nud_gram.Value), Calory = Convert.ToInt32(txt_kalori.Text) };

                secilenFood = null;
                myMeal.MealDetails.Add(mealDetail);
                FillList();
            }
        }

        void FillList()
        {
            lst_ogunDetay.Items.Clear();
            foreach (MealDetail item in myMeal.MealDetails)
            {
                Food food;
                if (secilenFood == null)
                    food = foodService.FindFoodByID(item.FoodID);
                else
                    food = foodService.FindFoodByID(secilenFood.FoodID);

                string baslik = myMeal.MealType == null ? cb_mealTypes.Text : myMeal.MealType.MealTypeName;

                ListViewItem lvi = new ListViewItem(baslik);
                lvi.SubItems.Add(food.Name);
                lvi.SubItems.Add(item.Grams.ToString());
                lvi.SubItems.Add(item.Calory.ToString());
                lvi.Tag = item;
                lst_ogunDetay.Items.Add(lvi);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = lst_ogunDetay.SelectedItems[0].Index;
            if ( index > -1)
            {
                myMeal.MealDetails.Remove((MealDetail)lst_ogunDetay.SelectedItems[0].Tag);
            }

            FillList();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (myMeal.MealID > 0)
                {
                    mealService.Update(myMeal);
                }
                else
                {
                    User user = userService.GetUserById(userid);
                    MealType mealType = mealTypeService.GetAllTypes().Where(x => x.MealTypeID == (int)cb_mealTypes.SelectedValue).FirstOrDefault();

                    myMeal.UserID = user.UserID;
                    myMeal.RegisterationDate = DateTime.Now;
                    myMeal.MealTypeID = mealType.MealTypeID;
                    myMeal.State = true;

                    mealService.Insert(myMeal);
                }

                MessageBox.Show("Öğün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearForm()
        {
            secilenFood = null;
            myMeal = new Meal();
            lst_ogunDetay.Items.Clear();
            txt_yemekAdi.Clear();
            txt_kalori.Clear();
            nud_gram.Value = nud_gram.Minimum;
        }
    }
}
