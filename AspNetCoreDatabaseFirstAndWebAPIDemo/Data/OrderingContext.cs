using AspNetCoreDatabaseFirstAndWebAPIDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Data
{
    public class OrderingContext : DbContext
    {
        public OrderingContext(DbContextOptions<OrderingContext> options) : base(options)
        {
        }

        public DbSet<CategoryInfo> Categories { get; set; }
    }
}