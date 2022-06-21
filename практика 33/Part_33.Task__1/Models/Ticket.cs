using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }

        public virtual ICollection<Season> Seasons { get; set; } = new HashSet<Season>();
        public virtual ICollection<TuristInformation> TuristInformations { get; set; } = new HashSet<TuristInformation>();
    }
}
