using CaloriMeter.DAL;
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
    public partial class AdminUserControl : Form
    {
        CalorieMeterDbContext context;
        User user;
        //BindingList<User> users1;
        public AdminUserControl()
        {
            context = new CalorieMeterDbContext();
            InitializeComponent();
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            AllUsers();
            //users1 = new BindingList<User>();  
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = context.Users.Where(u => u.Name.Contains(txtAra.Text)).ToList();
        }

        //private void txtAra_TextChanged(object sender, EventArgs e)
        //{
        // context = new CalorieMeterDbContext();
        // dgvListe.DataSource = context.Users.Where(u => u.Name.Contains(txtAra.Text)).ToList();
        //}

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            AllUsers();
        }

        void AllUsers()
        {
            var liste = context.Users.ToList();
            dgvListe.DataSource = liste;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //dgvListe.Rows.RemoveAt(dgvListe.SelectedRows[0].Index);
            //int rowIndex = dgvListe.CurrentCell.RowIndex;
            //dgvListe.Rows.RemoveAt(rowIndex);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dgvListe.Refresh();
            dgvListe.Update();
            context.SaveChanges();
        }
    }
}
