﻿using System;
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

        [Required]
        [MaxLength(50)]
        public String firstName { get; set; }

        [Required]
        [MaxLength(50)]
        public String lastName { get; set; }

        [Required]
        [MaxLength(50)]
        public String email { get; set; }

        [Required]
        [StringLength(10)]
        public String phoneNumber { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public int membershipID { get; set; }

        public virtual Memebership membership { get; set; }


    }
}
