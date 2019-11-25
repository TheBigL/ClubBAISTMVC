using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubBAISTMVC.Models
{
    public class Golfer
    {
        [Key]
        public int GolferID { get; set; }

        public String firstName { get; set; }

        public String lastName { get; set; }
    }
}
