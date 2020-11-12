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
    public partial class Error8point1_Raise : Form
    {
        public Error8point1_Raise()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error18point1_EndYes3 ey3 = new Error18point1_EndYes3();
            ey3.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error19point1_EndNo3 en3 = new Error19point1_EndNo3();
            en3.Show();
            Hide();
        }
    }
}
