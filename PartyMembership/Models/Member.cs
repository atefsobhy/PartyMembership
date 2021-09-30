using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required] 
        public string Email { get; set; }

        [Required] 
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [Required] 
        public int PartyId { get; set; }
        public Party Party { get; set; }
    }
}
