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
    public partial class Error16point1_GiveUpPlan : Form
    {
        public Error16point1_GiveUpPlan()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error5point1_Embezzle em2 = new Error5point1_Embezzle();
            em2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error15point1_TryAgain ta2 = new Error15point1_TryAgain();
            ta2.Show();
            Hide();
        }
    }
}
