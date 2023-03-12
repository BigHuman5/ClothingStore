using ClothingStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DAL.EF
{
    public class ClothingStoreDbContext : DbContext
    {
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        public DbSet<NamesDimensions> NamesDimensions { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<TypesDimensions> TypesDimensions { get; set; }
        public DbSet<TypesHuman> TypesHumans { get; set; }
        public ClothingStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Dimensions>()
            .HasOne(p => p.typeDimensions)
            .WithMany(t => t.Dimensions)
            .HasForeignKey(i => i.typeDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Dimensions>()
            .HasOne(p => p.nameDimensions)
            .WithMany(t => t.Dimensions)
            .HasForeignKey(i => i.nameDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TypesDimensions>()
            .HasOne(p => p.type)
            .WithMany(t => t.TypesDimensions)
            .HasForeignKey(i => i.typeId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TypesDimensions>()
            .HasOne(p => p.typeHuman)
            .WithMany(t => t.TypesDimensions)
            .HasForeignKey(i => i.typeHumanId)
            .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
