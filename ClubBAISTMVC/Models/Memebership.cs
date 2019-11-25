using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class Memebership
    {
        [Key]
        public int MembershipID { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Golfer> Golfers { get; set; }
    }
}
