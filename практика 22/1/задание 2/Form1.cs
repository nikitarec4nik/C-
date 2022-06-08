using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double es = 2.72, s = 0 ;
            double x = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double f = Math.Pow(x,2);
            if ((1 < x * b) & (x * b < 10))
            {
                s = Math.Pow(es, f);
            }
            else if ((12 < f) & (f < 40))
            {
                s = Math.Sqrt(Math.Abs(f + 4 * b));
            }
            else s = b * Math.Pow(f,2);
            
            textBox4.Text = Convert.ToString(s);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
