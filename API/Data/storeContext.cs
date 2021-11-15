using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class storeContext : DbContext
    {
        public storeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Product> Products { get; set; }
    }
}