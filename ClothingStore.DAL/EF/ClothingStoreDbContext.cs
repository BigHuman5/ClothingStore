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
        public DbSet<Category> Category { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<TypesHuman> TypesHumans { get; set; }

        public DbSet<Cards> Cards { get; set; }
        public DbSet<Products> Products { get; set; }

        //Dimensions
        public DbSet<CriteriaOfDimensions> CriteriaOfDimensions { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        public DbSet<UnionNamesCriteriaOfDimensions> UnionNamesCriteriaOfDimensions { get; set; }
        public DbSet<UnionNamesAndDimensions> UnionNamesAndDimensions { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<UnionCategoryAndTypeHuman> UnionCategoryAndTypeHuman { get; set; }
        public DbSet<NamesCriteriaOfDimensions> NamesCriteriaOfDimensions { get; set; }
        public DbSet<NamesDimensions> NamesDimensions { get; set; }

        //
        public DbSet<Collections> Collections { get; set; }
        public ClothingStoreDbContext(DbContextOptions options) : base(options)
        {
            new DbInitializer(this);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Размеры
            {
                builder.Entity<UnionNamesCriteriaOfDimensions>()
                    .HasOne(p => p.unionCategoryAndTypeHuman)
                    .WithMany(t => t.namesCriteria)
                    .HasForeignKey(i => i.UnionCategoryAndTypeHumanId)
                    .OnDelete(DeleteBehavior.SetNull);

                builder.Entity<UnionNamesAndDimensions>()
                .HasOne(p => p.unionCategoryAndTypeHuman)
                .WithMany(t => t.namesDimensions)
                .HasForeignKey(i => i.UnionCategoryAndTypeHumanId)
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

                builder.Entity<UnionCategoryAndTypeHuman>()
                .HasOne(p => p.category)
                .WithMany(t => t.TypesDimensions)
                .HasForeignKey(i => i.categoryId)
                .OnDelete(DeleteBehavior.SetNull);

                builder.Entity<UnionCategoryAndTypeHuman>()
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
            
            builder.Entity<Subcategory>()
                .HasOne(p => p.unionCategoryAndTypeHuman)
                .WithMany(t => t.subcategories)
                .HasForeignKey(i => i.unionCategoryAndTypeHumanId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Cards>()
                .HasOne(p => p.Subcategory)
                .WithMany(t => t.Cards)
                .HasForeignKey(i => i.subcategoryId)
                .OnDelete(DeleteBehavior.SetNull);
            

            builder.Entity<Cards>()
                .HasOne(p => p.Collections)
                .WithMany(t => t.Cards)
                .HasForeignKey(i => i.collectionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Cards>()
                .HasOne(p => p.Brand)
                .WithMany(t => t.Cards)
                .HasForeignKey(i => i.brandId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Products>()
                .HasOne(p => p.Colors)
                .WithMany(t => t.Products)
                .HasForeignKey(i => i.colorId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Products>()
                .HasOne(p => p.Sizes)
                .WithMany(t => t.Products)
                .HasForeignKey(i => i.sizeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
