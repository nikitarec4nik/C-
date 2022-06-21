using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class Tourist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TouristId { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
    }
}
