using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class StandingTeeTimeRequest
    {
        [Key]
        public int StandingTeeTimeRequestID { get; set; }
        [Required]
        public DateTime requestedTeeTime { get; set; }
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime endDate { get; set; }
        [Required]
        public int GolferID { get; set; }
        [Required]
        public int DailyTeeSheetID { get; set; }
        [Required]
        public virtual Golfer Golfer { get; set; }
        [Required]
        public virtual DailyTeeSheet DailyTeeSheet { get; set; }

    }
}
