using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class TeeTime
    {
        [Key]
        public int teetimeID { get; set; }
        [Required]
        public DateTime teeTime { get; set; }
        [Required]
        public int DailyTeeSheetID { get; set; }

        public virtual DailyTeeSheet DailyTeeSheet { get; set; }
    }
}
