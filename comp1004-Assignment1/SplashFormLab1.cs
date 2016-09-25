using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_Assignment1
{
    public partial class SplashFormLab1Form : Form
    {
        public SplashFormLab1Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;

            Lab1Form splashform = new Lab1Form();

            splashform.Show();
            this.Hide();
          
        }
    }
}
