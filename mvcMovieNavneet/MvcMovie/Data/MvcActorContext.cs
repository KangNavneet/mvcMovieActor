using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcActorContext : DbContext
    {
        public MvcActorContext(DbContextOptions<MvcActorContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Movie { get; set; }
    }
}
