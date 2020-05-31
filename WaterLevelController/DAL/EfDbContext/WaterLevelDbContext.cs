using Microsoft.EntityFrameworkCore;
namespace WaterLevelController.DAL.EfDbContext
{
    public class WaterLevelDbContext : DbContext
    {


        public WaterLevelDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=WaterLevelDb;Trusted_Connection=True;").UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Switch> Switches { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
