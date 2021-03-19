using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5TurkceIngilizceKarakter
{
    public partial class Form1 : Form
    {
        Transformation T1;
        public Form1()
        {
            InitializeComponent();
            T1 = new Transformation();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            string input = rtbInput.Text;
            rtbOutput.Text = T1.Transform(input);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            rtbInput.Text = string.Empty;
            rtbOutput.Text = string.Empty;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to quit this application?";
            string title = "Quit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
