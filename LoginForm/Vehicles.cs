using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void BtnBackVehicles_Click(object sender, EventArgs e)
        {
            DashboardForm df = new DashboardForm("userID");
            this.Hide();
            df.Show();
        }
    }
}
