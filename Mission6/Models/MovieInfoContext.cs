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
        public DbSet<Category> Categories { get; set; }        
        //Seeding data base
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );



            mb.Entity<TrackerEntry>().HasData(

                new TrackerEntry
                {
                    EntryID = 1,
                    CategoryId = 1,
                    Title = "Avatar: Way of Water",
                    Year = 2022,
                    Director = "James Cameron",
                    Rating = "PG-13",
                    Notes = "Saw it twice in theaters"
                },
                new TrackerEntry
                {
                    EntryID = 2,
                    CategoryId = 3,
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
                    CategoryId = 1,
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
