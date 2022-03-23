using eCommerceBasketApp.Models.Cart;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBasketApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardItem> CardItems { get; set; }

    }
}
