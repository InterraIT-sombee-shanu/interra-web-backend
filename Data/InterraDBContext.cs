using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Data
{
    public class InterraDBContext : DbContext
    {
        public InterraDBContext(DbContextOptions<InterraDBContext> options): base(options)
        {
        }

        public DbSet<QuickLinks> QuickLinks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=InterraWebDB;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=InterraWebDB;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
