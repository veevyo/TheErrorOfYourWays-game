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
    public partial class Error12point1_Fired : Form
    {
        public Error12point1_Fired()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error13point1_EndYes2 ey2 = new Error13point1_EndYes2();
            ey2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error14point1_EndNo2 en2 = new Error14point1_EndNo2();
            en2.Show();
            Hide();
        }
    }
}
