using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using API.DTOs;

namespace API.Data
{
    public class NewsRepository : INewsRepository
    {
        private readonly DataContext _context;
        public NewsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<NewsE>> GetNewsAsync(NewsDto n)
        {
            
            return await _context.NewsTbl.Where(x => (string.IsNullOrEmpty(n.NewsType) || x.NewsType == n.NewsType)
                                                  && (string.IsNullOrEmpty(n.NewsText) || x.NewsText.Contains(n.NewsText))).ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}