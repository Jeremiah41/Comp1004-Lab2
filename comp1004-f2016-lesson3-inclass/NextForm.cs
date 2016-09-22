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

    public StartForm previousForm { get; set; }

    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            showPreviousForm();
        }

        private void showPreviousForm()
        {
            //show previous form
            this.previousForm.Show();
            // close down this form
            this.Close();
        }

        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm going back", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                showPreviousForm();
            }
            Application.Exit();
        }
    }
}
