using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    public class CMS_DBContext : DbContext
    {
        public CMS_DBContext(DbContextOptions<CMS_DBContext> options) : base(options)
        {
        }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<CategoryNews> CategoryNewses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImageses { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetailses { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().ToTable("Accounts");
            modelBuilder.Entity<CategoryNews>().ToTable("CategoryNews");
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductImages>().ToTable("ProductImages");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails");
            modelBuilder.Entity<OrderStatus>().ToTable("OrderStatus");
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Roles>().ToTable("Roles");
        }

    }
}
