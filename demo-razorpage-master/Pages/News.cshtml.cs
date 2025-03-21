using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Models;
using NewsWebsite.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsWebsite.Pages
{
    
    public class NewsModel : PageModel
    {
        private readonly NewsDbContext _context;
        public List<NewsArticle> NewsList { get; set; } = new();

        public NewsModel(NewsDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            NewsList = await _context.News.ToListAsync();
        }
    }
}
