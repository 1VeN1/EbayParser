using System.Data.Entity;

namespace EbayParser
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
        public virtual DbSet<Products> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.Smartphones)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerID);
        }
    }
}
