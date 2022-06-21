using Microsoft.EntityFrameworkCore;
using Part_33.Task__1.Models;
using Part_33.Task__1.Windows;
using System.Linq;
using System.Windows;

namespace Part_33.Task__1
{
    public partial class MainWindow : Window
    {
        private readonly AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();

            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Data Source=DESKTOP-T9IBF8L;Initial Catalog=lab34_1;Integrated Security=SSPI;")
                .Options);

            _context.Database.EnsureCreated();

            RefreshTuristsGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new TuristWindow();
            dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                _context.Turists.Add(dialog.Tourist);
                _context.SaveChanges();
            }

            RefreshTuristsGrid();
        }

        private void RefreshTuristsGrid()
        {
            TouristGrid.DataContext = _context.Turists.ToList();
        }

        private void Deletebutton_Click(object sender, RoutedEventArgs e)
        {
            var item = TouristGrid.SelectedItem as Tourist;
            var entity = _context.Turists.First(x => x.TouristId == item.TouristId);

            _context.Turists.Remove(entity);
            _context.SaveChanges();

            RefreshTuristsGrid();
        }
    }
}
