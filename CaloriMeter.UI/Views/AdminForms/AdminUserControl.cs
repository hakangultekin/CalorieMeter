
using CaloriMeter.BLL.Services;
using CaloriMeter.DAL;
using CaloriMeter.Model.Entitites;
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

namespace CaloriMeter.UI.Views.AdminForms
{
    public partial class AdminUserControl : Form
    {
        UserService userService;
        User user;
        public AdminUserControl()
        {
            userService = new UserService();
            InitializeComponent();
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            FillList(userService.GetAllUsers());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text.Length > 1)
                FillList(userService.FindUser(txtAra.Text));

            if (string.IsNullOrWhiteSpace(txtAra.Text))
                FillList(userService.GetAllUsers());
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            FillList(userService.GetAllUsers());
        }

        void FillList(List<User> users)
        {
            lst_users.Items.Clear();

            foreach (User usr in users)
            {
                ListViewItem lvi = new ListViewItem(usr.Name);
                lvi.SubItems.Add(usr.LastName);
                lvi.SubItems.Add(usr.UserName);
                lvi.SubItems.Add(usr.Gender.ToString());
                lvi.SubItems.Add(usr.BirthDate.ToShortDateString());
                lvi.SubItems.Add(usr.State.ToString());
                lvi.Tag = usr;

                lst_users.Items.Add(lvi);
            }
        }

        private void btn_getPassives_Click(object sender, EventArgs e)
        {
            FillList(userService.GetPasiveUsers());
        }

        private void lst_users_DoubleClick(object sender, EventArgs e)
        {
            int index = lst_users.SelectedItems[0].Index;
            if (index > -1)
            {
                User user = (User)lst_users.SelectedItems[0].Tag;
                UpdateInfo updateInfo = new UpdateInfo(user);
                updateInfo.ShowDialog();

                userService = new UserService();
                FillList(userService.GetAllUsers());
            }
        }

        private void btn_aktiflestir_Click(object sender, EventArgs e)
        {
            
            if (lst_users.SelectedItems.Count > 0)
            {
                int index = lst_users.SelectedItems[0].Index;
                User user = (User)lst_users.SelectedItems[0].Tag;
                user.State = !user.State;
                userService.Update(user);
                FillList(userService.GetAllUsers());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
