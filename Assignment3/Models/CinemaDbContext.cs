using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class CinemaDbContext : DbContext
    {
        //Tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<CharacterMovie> CharacterMovies { get; set; }

        public CinemaDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ND-5CG9030M8H\\SQLEXPRESS;Initial Catalog=CinemaDb;Integrated Security=True;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CharacterMovie>()
                        .HasKey(cm => new { cm.CharacterId, cm.MovieId });
            modelBuilder.Entity<CharacterMovie>()
                        .HasOne(cm => cm.Character)
                        .WithMany(c => c.CharacterMovies)
                        .HasForeignKey(cm => cm.CharacterId);
            modelBuilder.Entity<CharacterMovie>()
                        .HasOne(cm => cm.Movie)
                        .WithMany(m => m.CharacterMovies)
                        .HasForeignKey(cm => cm.MovieId);

            //SEEDING THE DATABASE
            //Franchise
            modelBuilder.Entity<Franchise>().HasData(new Franchise { Id = 1, Name = "Marvel", Description = "Superheroes that always somehow manages to save the world" });
            modelBuilder.Entity<Franchise>().HasData(new Franchise { Id = 2, Name = "Lord of the Rings", Description = "The best trilogy ever made." });
            modelBuilder.Entity<Franchise>().HasData(new Franchise { Id = 3, Name = "Harry Potter", Description = "Wizard boy goes to school, but something goes wrong every year" });
            //Movies
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Title = "The Avengers", Genre = "Action", ReleaseYear = DateTime.Parse("2012-01-01"), Director = "Joss Whedon", Picture = "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY1200_CR90,0,630,1200_AL_.jpg", Trailer = "https://www.youtube.com/watch?v=eOrNdBpGMv8", FranchiseId = 1 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 2, Title = "Thor: Ragnarok", Genre = "Action", ReleaseYear = DateTime.Parse("2017-01-01"), Director = "Taika Waititi", Picture = "https://www.bing.com/th?id=A70092af279de08fc0762746dbdc6be61&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=ue80QwXMRHg", FranchiseId = 1 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 3, Title = "Spiderman: No way home", Genre = "Action", ReleaseYear = DateTime.Parse("2021-01-01"), Director = "Jon Watts", Picture = "https://www.bing.com/th?id=Acd021478a99c6e1a187ebda0f186c36e&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=JfVOs4VSpmA", FranchiseId = 1 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 4, Title = "Lord of the Rings: The Fellowship of the Ring", Genre = "Fantasy", ReleaseYear = DateTime.Parse("2001-01-01"), Director = "Peter Jackson", Picture = "https://www.bing.com/th?id=Acd16d948d57a0e5c13b41182f01a9603&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=cKEGZ-CvWHk", FranchiseId = 2 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 5, Title = "Lord of the Rings: The Two Towers", Genre = "Fantasy", ReleaseYear = DateTime.Parse("2002-01-01"), Director = "Peter Jackson", Picture = "https://www.bing.com/th?id=Ac317d10bbc9daae44750cb84536c5802&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=LbfMDwc4azU", FranchiseId = 2 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 6, Title = "Lord of the Rings: The Return of the King", Genre = "Fantasy", ReleaseYear = DateTime.Parse("2003-01-01"), Director = "Peter Jackson", Picture = "https://www.bing.com/th?id=A3bad55d4843d18e2809ce35612614455&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=KOQSQaGgJxs", FranchiseId = 2 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 7, Title = "Harry Potter and the Philosopher's Stone", Genre = "Fantasy", ReleaseYear = DateTime.Parse("2001-01-01"), Director = "Chris Colombus", Picture = "https://www.bing.com/th?id=Ab77398b331e251965a55ab9e9a2dfbd7&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", Trailer = "https://www.youtube.com/watch?v=6kkUw717s2w", FranchiseId = 3 });
            //Characters
            modelBuilder.Entity<Character>().HasData(new Character { Id = 1, CharacterName = "Tony Stark", Alias = "Iron Man", Gender = "Male", Picture = ""});
            modelBuilder.Entity<Character>().HasData(new Character { Id = 2, CharacterName = "Thor", Alias = "", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 3, CharacterName = "Peter Parker", Alias = "Spider Man", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 4, CharacterName = "Black Widow", Alias = "", Gender = "Female", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 5, CharacterName = "Aragorn", Alias = "Strider", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 6, CharacterName = "Legolas", Alias = "", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 7, CharacterName = "Gimli", Alias = "", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 8, CharacterName = "Harry Potter", Alias = "The boy who lived", Gender = "Male", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 9, CharacterName = "Hermoine Granger", Alias = "", Gender = "Female", Picture = "" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 10, CharacterName = "Ron Weasly", Alias = "", Gender = "Male", Picture = "" });
            //CharacterMovie - What characters are in what movie
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 1, MovieId = 1});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 2, MovieId = 1});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 2, MovieId = 2});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 3, MovieId = 3});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 4, MovieId = 1});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 5, MovieId = 4});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 5, MovieId = 5});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 5, MovieId = 6});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 6, MovieId = 4});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 6, MovieId = 5});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 6, MovieId = 6});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 7, MovieId = 4});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 7, MovieId = 5});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 7, MovieId = 6});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 8, MovieId = 7});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 9, MovieId = 7});
            modelBuilder.Entity<CharacterMovie>().HasData(new CharacterMovie { CharacterId = 10, MovieId = 7});
            
        }
    }
}
