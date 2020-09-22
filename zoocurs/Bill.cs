using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoocurs
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            this.button1.BackColor = System.Drawing.Color.Transparent;
          this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
