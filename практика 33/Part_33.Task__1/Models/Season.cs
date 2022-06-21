using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class Season
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeasonId { get; set; }
        public int TicketId { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsClosed { get; set; }
        public int Count { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<Tur> Turs { get; set; } = new HashSet<Tur>();
    }
}
