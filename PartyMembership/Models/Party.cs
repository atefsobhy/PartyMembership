using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.Models
{
    public class Party
    {
        public int PartyId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Estabslished { get; set; }
        public string AddressLine1 { get; set; }
        public string TownCity { get; set; }
        public string PostCode { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
