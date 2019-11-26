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


        public ClubBAISTDbContext(DbContextOptions<ClubBAISTDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
