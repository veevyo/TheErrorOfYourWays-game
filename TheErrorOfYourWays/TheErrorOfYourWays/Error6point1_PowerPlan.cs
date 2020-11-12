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
    public partial class Error6point1_PowerPlan : Form
    {
        public Error6point1_PowerPlan()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error15point1_TryAgain ta1 = new Error15point1_TryAgain();
            ta1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error16point1_GiveUpPlan gu1 = new Error16point1_GiveUpPlan();
            gu1.Show();
            Hide();
        }
    }
}
