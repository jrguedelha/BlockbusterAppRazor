using BlockbusterAppRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockbusterAppRazor.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base (options) {}

        public DbSet<MovieModel> Movies { get; set; }
    }
}
