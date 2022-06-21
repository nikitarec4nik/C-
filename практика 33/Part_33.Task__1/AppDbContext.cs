using Microsoft.EntityFrameworkCore;
using Part_33.Task__1.Models;

namespace Part_33.Task__1
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Tourist> Turists { get; set; }
        public DbSet<Tur> Turs { get; set; }
        public DbSet<TuristInformation> TuristInformations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
