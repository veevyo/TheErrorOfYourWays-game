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
    public partial class Error3point1_Promotion : Form
    {
        public Error3point1_Promotion()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error5point1_Embezzle em1 = new Error5point1_Embezzle();
            em1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error6point1_PowerPlan pp1 = new Error6point1_PowerPlan();
            pp1.Show();
            Hide();
        }
    }
}
