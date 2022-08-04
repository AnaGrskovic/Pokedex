using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PokeDex.Contracts.Models;

namespace PokeDex.Data.Db.Configurations
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Pokemon> Pokemon { get; set; } = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}

