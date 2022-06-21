using System.Data.Linq.Mapping;

namespace WindowsFormsApp1.Models
{
    [Table(Name = "Туристы")]
    internal class Turist
    {
        [Column(Name="КодТуриста", IsPrimaryKey =true, IsDbGenerated =true)]
        public int Id { get; set; }

        [Column(Name="Имя")]
        public string FirstName { get; set; }

        [Column(Name="Фамилия")]
        public string SecondName { get; set; }

        [Column(Name="Отчество")]
        public string LastName { get; set; }
    }
}
