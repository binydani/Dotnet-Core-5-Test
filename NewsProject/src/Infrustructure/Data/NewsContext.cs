using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrustructure.Data
{
    class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext>options) : base (options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
