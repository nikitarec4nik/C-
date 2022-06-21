using System.Data.Linq;

namespace WindowsFormsApp1.Models
{
    internal class TuristyDbContext : DataContext
    {
        public Table<Turist> Turists{ get; set; }

        public TuristyDbContext(string connectionString): base(connectionString) { }
    }
}
