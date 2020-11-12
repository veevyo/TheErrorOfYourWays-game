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
    public partial class Error1_ChooseMajor : Form
    {
        public Error1_ChooseMajor()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error2point1_ChooseJob cj1 = new Error2point1_ChooseJob();
            cj1.Show();
            Hide();
        }
    }
}
