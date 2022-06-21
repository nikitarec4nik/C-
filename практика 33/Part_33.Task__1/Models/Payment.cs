using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        public int TicketId { get; set; }

        public DateTime Date { get; set; }
        public decimal Sum { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
