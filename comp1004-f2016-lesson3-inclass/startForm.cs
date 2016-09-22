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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
           MessageLabel.Text = (MessageLabel.Text == "Hello") ? "Good bye" : "Hello";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            // instantiate the next form
            NextForm nextForm = new NextForm();
            //save the reference for the current form in the peroperty of th nextForm
            nextForm.previousForm = this;
            // Show the next form
            nextForm.Show();

            //hide current form
            this.Hide();
        }
    }
}
