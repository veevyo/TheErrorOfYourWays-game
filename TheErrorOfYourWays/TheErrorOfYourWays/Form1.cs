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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error1_ChooseMajor cm = new Error1_ChooseMajor();
            cm.Show();
            Hide();
        }
    }
}
