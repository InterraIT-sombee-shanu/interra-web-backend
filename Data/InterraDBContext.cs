using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Data
{
    public class InterraDBContext : DbContext
    {
        public InterraDBContext(DbContextOptions<InterraDBContext> options): base(options)
        {
        }

        public DbSet<QuickLinks> QuickLinks { get; set; }

        public DbSet<Webinar> Webinars { get; set; }

        public DbSet<ClientFeedback> ClientFeedbacks { get; set; }

        public DbSet<StrategicPartner> StrategicPartners { get; set; }


        public DbSet<Query> Queries { get; set; }


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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ignore the 'QuickLinks' table during migrations
           // modelBuilder.Ignore<QuickLinks>();
            //modelBuilder.Ignore<Webinar>();

            // Other model configurations...
        }

    }
}
