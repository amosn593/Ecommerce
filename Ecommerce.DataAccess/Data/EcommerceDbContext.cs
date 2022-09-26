using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Data
{
    public class EcommerceDbContext: DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
