namespace AuctionPlace.DAL
{
    using AuctionPlace.DAL.DTO;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<UserDTO, IdentityRole<int>, int>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.SeedRoles(modelBuilder);
        }

        public DbSet<AuctionConfigDTO> AuctionConfig { get; set; }

        public DbSet<AuctionDTO> Auctions { get; set; }

        public DbSet<ProductDTO> Products { get; set; }

        public DbSet<BidDTO> Bids { get; set; }

        public DbSet<CategoryCategoryDTO> CategoryCategory { get; set; }

        public DbSet<CategoryDTO> Categories { get; set; }

        public DbSet<ProductCategoryDTO> ProductCategory { get; set; }

        public DbSet<UserScoringDTO> UserScorings { get; set; }

        public DbSet<WalletDTO> Wallets { get; set; }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 1, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole<int>() { Id = 2, Name = "Bidder", ConcurrencyStamp = "2", NormalizedName = "Bidder" },
                new IdentityRole<int>() { Id = 3, Name = "Offerer", ConcurrencyStamp = "3", NormalizedName = "Offerer" }
                );
        }
    }
}
