using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.Modell;

namespace WaterLevelController.Db
{
    public class WaterLevelControllerContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=WaterLevelController;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRanch>().HasKey(ur => new { ur.UserId, ur.RanchId });

            modelBuilder.Entity<UserRanch>()
                .HasOne<User>(ur => ur.User)
                .WithMany(u => u.UserRanch)
                .HasForeignKey(ur => ur.UserId);


            modelBuilder.Entity<UserRanch>()
                .HasOne<Ranch>(ur => ur.Ranch)
                .WithMany(r => r.UserRanch)
                .HasForeignKey(ur => ur.RanchId);
        }

        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Switch> Switches { get; set; }
        public DbSet<Ranch> Ranches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRanch> UserRanches { get; set; }

    }
}
