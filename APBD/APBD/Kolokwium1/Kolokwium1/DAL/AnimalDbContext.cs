namespace Kolokwium1.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnimalDbContext : DbContext
    {
        public AnimalDbContext()
            : base("name=AnimalDbContext1")
        {
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<AnimalType> AnimalType { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AnimalType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.LastName)
                .IsUnicode(false);
        }
    }
}
