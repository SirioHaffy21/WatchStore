using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WatchManageStore.Data.SeedData;
using WatchManageStore.Models;

namespace WatchManageStore.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Watch> Watchs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DetailWatch> DetailWatchs { get; set; }
        public DbSet<RateAccount> RateAccounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrandSeedData());
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new CommentSeedData());
            modelBuilder.ApplyConfiguration(new PostSeedData());
            modelBuilder.ApplyConfiguration(new StoreSeedData());
            modelBuilder.ApplyConfiguration(new WatchSeedData());
            modelBuilder.ApplyConfiguration(new DetailWatchSeedData());
            modelBuilder.ApplyConfiguration(new RateAccountSeedData());
        }

    }

}
