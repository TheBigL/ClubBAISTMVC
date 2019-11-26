using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClubBAISTMVC.Models
{
    public class ClubBAISTDbContext : DbContext
    {
        public DbSet<Golfer> Golfers { get; set; }

        public DbSet<DailyTeeSheet> DailyTeeSheets { get; set; }

        public DbSet<Memebership> Memeberships { get; set; }

        public DbSet<StandingTeeTimeRequest> StandingTeeTimeRequests { get; set; }

        public DbSet<TeeTime> TeeTimes { get; set; }


        public ClubBAISTDbContext(DbContextOptions<ClubBAISTDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
