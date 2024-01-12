using Microsoft.EntityFrameworkCore;

namespace Will.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet <ProductModel> Products { get; set; }
    }
}
