using ClothingStore.DAL.Entities;
using ClothingStore.DAL.Entities.Dimensions;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DAL.EF
{
    public class ClothingStoreDbContext : DbContext
    {
        //Main
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<TypesHuman> TypesHumans { get; set; }
        //Dimensions
        public DbSet<CriteriaOfDimensions> CriteriaOfDimensions { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        public DbSet<UnionNamesCriteriaOfDimensions> UnionNamesCriteriaOfDimensions { get; set; }
        public DbSet<UnionNamesAndDimensions> UnionNamesAndDimensions { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<TypesDimensions> TypesDimensions { get; set; }
        public DbSet<NamesCriteriaOfDimensions> NamesCriteriaOfDimensions { get; set; }
        public DbSet<NamesDimensions> NamesDimensions { get; set; }
        public ClothingStoreDbContext(DbContextOptions options) : base(options)
        {
            new DbInitializer(this);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UnionNamesCriteriaOfDimensions>()
            .HasOne(p => p.typesDimensions)
            .WithMany(t => t.namesCriteria)
            .HasForeignKey(i => i.typesDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<UnionNamesAndDimensions>()
            .HasOne(p => p.typeDimensions)
            .WithMany(t => t.namesDimensions)
            .HasForeignKey(i => i.typeDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<CriteriaOfDimensions>()
            .HasOne(p => p.namesCriteriaOfDimensions)
            .WithMany(t => t.criteriaOfDimensions)
            .HasForeignKey(i => i.namesCriteriaOfDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Sizes>()
            .HasOne(p => p.namesDimensions)
            .WithMany(t => t.sizes)
            .HasForeignKey(i => i.namesDimensionsId)
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

            builder.Entity<Dimensions>()
            .HasOne(p => p.CriteriaOfDimensions)
            .WithMany(t => t.dimensions)
            .HasForeignKey(i => i.CriteriaOfDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Dimensions>()
            .HasOne(p => p.sizes)
            .WithMany(t => t.Dimensions)
            .HasForeignKey(i => i.sizesId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<UnionNamesAndDimensions>()
            .HasOne(p => p.NamesDimensions)
            .WithMany(t => t.union)
            .HasForeignKey(i => i.NamesDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<UnionNamesCriteriaOfDimensions>()
            .HasOne(p => p.NamesCriteriaOfDimensions)
            .WithMany(t => t.union)
            .HasForeignKey(i => i.NamesCriteriaOfDimensionsId)
            .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
