using BlockbusterAppRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockbusterAppRazor.Data
{
    public class GenresDbContext : DbContext
    {
        public GenresDbContext(DbContextOptions<GenresDbContext> options) : base(options) { }

        public DbSet<GenreModel> Genres { get; set; }
    }
}
