using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2Sample.Models
{
    public class PlayerDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s17110;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("PlayerSample");
                entity.HasKey(e => e.IdPlayer);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(150);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(150);
                entity.Property(e => e.IdTeam).IsRequired();
                entity.HasOne<Team>(p => p.Team)
                        .WithMany(t => t.Players)
                        .HasForeignKey(t => t.IdTeam);
            });
            
            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("TeamSample");
                entity.HasKey(e => e.IdTeam);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
