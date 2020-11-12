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
    public partial class Error4point1_ColdWar : Form
    {
        public Error4point1_ColdWar()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error3point1_Promotion q1 = new Error3point1_Promotion();
            q1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error8point1_Raise ra1 = new Error8point1_Raise();
            ra1.Show();
            Hide();
        }
    }
}
