using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guitar
{
    public partial class Formstart : Form
    {
        public Formstart()
        {
            InitializeComponent();
        }

        private void Formstart_Load(object sender, EventArgs e)
        {
            label2.Text = "version:1.0.2\nproduced by:nnnuchang";
            
            //timer1.Interval = 3000;
            //timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 f1 = new Form1();
            //f1.Hide();
            //timer1.Enabled = false;

        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
