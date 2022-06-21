using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Part_33.Task__1.Models
{
    public class TuristInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TuristInformationId { get; set; }
        public int TirustId { get; set; }

        public string SerialNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Index { get; set; }

        public virtual Tourist Turists { get; set; }
    }
}
