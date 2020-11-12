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
    public partial class Error2point1_ChooseJob : Form
    {
        public Error2point1_ChooseJob()
        {
            InitializeComponent();
            this.Icon = ViviannePurvis_TAG_TheErrorOfYourWays.Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error3point1_Promotion p1 = new Error3point1_Promotion();
            p1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error4point1_ColdWar cw1 = new Error4point1_ColdWar();
            cw1.Show();
            Hide();
        }
    }
}
