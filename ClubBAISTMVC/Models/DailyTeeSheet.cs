using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class DailyTeeSheet
    {
        public int DailyTeeSheetID { get; set; }
        public DateTime date { get; set; }
        public int numberOfPlayers { get; set; }

        public int numberOfCarts { get; set; }

        public int golferID { get; set; }

        public ICollection<TeeTime> teeTimes { get; set; }

        public virtual Golfer golfer { get; set; }
    }
}
