using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly TuristyDbContext _context;

        public Form1()
        {
            InitializeComponent();

            _context = new TuristyDbContext(@"Data Source=C:\Users\noste\OneDrive\Рабочий стол\Lab30.accdb");

            textBox1.Text = string.Join("\n\r",
                _context.Turists.Select(x => $"{x.Id}; {x.FirstName}; {x.SecondName}; {x.LastName}"));
        }
    }
}
