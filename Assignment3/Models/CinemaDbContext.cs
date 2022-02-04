using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<CharacterMovie> CharacterMovies { get; set; }

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
        }
    }
}
