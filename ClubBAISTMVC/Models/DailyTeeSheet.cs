using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class DailyTeeSheet
    {
        [Key]
        public int DailyTeeSheetID { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public int numberOfPlayers { get; set; }
        [Required]
        public int numberOfCarts { get; set; }
        [Required]
        public int golferID { get; set; }

        public virtual ICollection<TeeTime> teeTimes { get; set; }

        public virtual Golfer golfer { get; set; }
    }
}
