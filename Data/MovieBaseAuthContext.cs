using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieBaseAuth.Models
{
    public class MovieBaseAuthContext : DbContext
    {
        public MovieBaseAuthContext (DbContextOptions<MovieBaseAuthContext> options)
            : base(options)
        {
        }

        public DbSet<MovieBaseAuth.Models.Movie> Movie { get; set; }
    }
}
