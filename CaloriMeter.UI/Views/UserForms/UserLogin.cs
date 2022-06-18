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

namespace CaloriMeter.UI.Views.UserForms
{
    public partial class UserLogin : Form
    {
        User user;
        public UserLogin(User _user)
        {
            InitializeComponent();
            user = _user;
        }

    }
}
