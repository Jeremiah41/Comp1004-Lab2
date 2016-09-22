using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_f2016_lesson3_inclass
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashformTimer.Enabled = false;

            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide;
        }
    }
}
