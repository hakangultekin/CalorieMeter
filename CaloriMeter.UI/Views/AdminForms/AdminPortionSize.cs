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

namespace CaloriMeter.UI.Views.AdminForms
{
    public partial class AdminPortionSize : Form
    {
        public AdminPortionSize()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(PortionSize)))
            {
                cbPorsTip.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
