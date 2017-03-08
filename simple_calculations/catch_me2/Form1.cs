using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_me2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonCatchMe_Click(object sender, EventArgs e)
        {

        }

        private void button_CatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();

            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;

            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;

            this.buttonCatchMe.Location = new Point(

            rand.Next(maxWidth), rand.Next(maxHeight));

            MessageBox.Show("The calculations are complete", "My Application",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
