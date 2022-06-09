using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Black, 2);
        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            ///клавиатура
            g.DrawLine(pen, 250, 250, 250, 260);
            g.DrawLine(pen, 250, 260, 350, 260);
            g.DrawLine(pen, 350, 260, 350, 250);
            g.DrawLine(pen, 350, 250, 250, 250);
            ///монитор
            g.DrawLine(pen, 270, 230, 270, 170);
            g.DrawLine(pen, 270, 170, 330, 170);
            g.DrawLine(pen, 330, 170, 330, 230);
            g.DrawLine(pen, 330, 230, 270, 230);
            ///ножка
            g.DrawLine(pen, 295, 230, 295, 250);
            g.DrawLine(pen, 305, 230, 305, 250);
            ///системник
            g.DrawLine(pen, 380, 170, 380, 260);
            g.DrawLine(pen, 380, 260, 420, 260);
            g.DrawLine(pen, 420, 260, 420, 170);
            g.DrawLine(pen, 420, 170, 380, 170);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
