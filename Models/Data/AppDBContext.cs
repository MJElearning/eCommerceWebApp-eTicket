using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(x => new { x.ActorId, x.MovieId });
            modelBuilder.Entity<Actor_Movie>().HasOne(y => y.Movie).WithMany(m => m.ActorMovies).HasForeignKey(key => key.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(z => z.Actor).WithMany(m => m.ActorMovie).HasForeignKey(key => key.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
