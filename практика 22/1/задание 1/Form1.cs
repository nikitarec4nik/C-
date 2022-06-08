using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0.1722;
            double y = 6.33;
            double z = 3.25*Math.Pow(10, -4);
            double f = 5*Math.Atan(x)-(1/4)*Math.Acos(x)*(x+3*Math.Abs(x-y)+Math.Pow(x, 2))/(Math.Abs(x-y)*z+Math.Pow(x,2));
            textBox3.Text = f.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
