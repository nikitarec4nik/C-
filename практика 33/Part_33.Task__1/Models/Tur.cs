using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class Tur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurId { get; set; }
        public int SeasonId { get; set; }

        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Information { get; set; }

        public virtual Season Season { get; set; }
    }
}
