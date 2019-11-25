using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class TeeTime
    {
        public DateTime teeTime { get; set; }
        public int DailyTeeSheetID { get; set; }

        public virtual DailyTeeSheet DailyTeeSheet { get; set; }
    }
}
