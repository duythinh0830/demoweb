using Microsoft.EntityFrameworkCore;

namespace NewsWebsite.Data
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options) { }

        public DbSet<NewsWebsite.Models.NewsArticle> News { get; set; }
    }
}
