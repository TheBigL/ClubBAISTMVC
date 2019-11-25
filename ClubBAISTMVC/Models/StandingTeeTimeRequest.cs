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

        public DateTime requestedTeeTime { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int GolferID { get; set; }

        public int DailyTeeSheetID { get; set; }

        public virtual Golfer Golfer { get; set; }

        public virtual DailyTeeSheet DailyTeeSheet { get; set; }

    }
}
