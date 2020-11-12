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
    public partial class Error5point1_Embezzle : Form
    {
        public Error5point1_Embezzle()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error9point1_Arrest ar1 = new Error9point1_Arrest();
            ar1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error12point1_Fired fi1 = new Error12point1_Fired();
            fi1.Show();
            Hide();
        }
    }
}
