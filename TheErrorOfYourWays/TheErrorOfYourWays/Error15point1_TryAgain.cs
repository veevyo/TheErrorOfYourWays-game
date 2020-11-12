using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViviannePurvis_TAG_TheErrorOfYourWays
{
    public partial class Error15point1_TryAgain : Form
    {
        public Error15point1_TryAgain()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error17point1_EndYesNo eyn = new Error17point1_EndYesNo();
            eyn.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error17point1_EndYesNo eyn = new Error17point1_EndYesNo();
            eyn.Show();
            Hide();
        }
    }
}
