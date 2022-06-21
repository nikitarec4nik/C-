using Part_33.Task__1.Models;
using System.Windows;

namespace Part_33.Task__1.Windows
{
    public partial class TuristWindow : Window
    {
        public Tourist Tourist { get; private set; }

        public TuristWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tourist = new Tourist
            {
                FirstName = boxfirst.Text,
                SecondName = boxsecond.Text,
                LastName = boxlast.Text
            };

            DialogResult = true;
        }
    }
}
