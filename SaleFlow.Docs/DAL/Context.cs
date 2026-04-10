using Microsoft.EntityFrameworkCore;
using Entities;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Quote> quotes { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //todo
        }
    }
}