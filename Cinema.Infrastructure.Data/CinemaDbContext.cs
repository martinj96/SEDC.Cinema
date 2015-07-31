using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
            : base("DefaultConnection")
        {

        }
        public CinemaDbContext(string cnnString)
            : base(cnnString)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actor { get; set; }

    }
}
