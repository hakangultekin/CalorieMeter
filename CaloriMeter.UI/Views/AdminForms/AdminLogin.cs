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
    public partial class AdminLogin : Form
    {
        User user;
        public AdminLogin(User _user)
        {
            InitializeComponent();
            user = _user;
        }
    }
}
