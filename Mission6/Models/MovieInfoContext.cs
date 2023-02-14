using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieInfoContext : DbContext
    {
        //not sure what this does
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
        {
            //Leave blank for now
        }
        public DbSet<TrackerEntry> entries { get; set; }
        //Seeding data base
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TrackerEntry>().HasData(
                new TrackerEntry
                {
                    EntryID = 1,
                    Category = "Sci-Fi",
                    Title = "Avatar: Way of Water",
                    Year = 2022,
                    Director = "James Cameron",
                    Rating = "PG-13",
                    Notes = "Saw it twice in theaters"
                },
                new TrackerEntry
                {
                    EntryID = 2,
                    Category = "Historical",
                    Title = "Unbroken",
                    Year = 2014,
                    Director = "Angelina Jolie",
                    Rating = "PG-13",
                    LentTo = "Mitchell",
                    Notes = "Very inspirational"
                },
                new TrackerEntry
                {
                    EntryID = 3,
                    Category = "Action/Adventure",
                    Title = "Top Gun: Maverick",
                    Year = 2022,
                    Director = "Joseph Kosinski",
                    Rating = "PG-13",
                    LentTo = "Ryan",
                    Notes = "Almost made me join AF"
                }
            );
        }
    }
}
