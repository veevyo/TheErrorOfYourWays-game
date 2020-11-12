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
    public partial class Error9point1_Arrest : Form
    {
        public Error9point1_Arrest()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error10point1_EndYes1 ey1 = new Error10point1_EndYes1();
            ey1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error11point1_EndNo1 en1 = new Error11point1_EndNo1();
            en1.Show();
            Hide();
        }
    }
}
