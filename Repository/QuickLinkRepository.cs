using InterraWebBackend.Data;
using InterraWebBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Repository
{
    
    public class QuickLinkRepository : IQuickLinkRepository
    {
        private readonly InterraDBContext _context;

        public QuickLinkRepository(InterraDBContext context)
        {
            _context = context;
        }

        public async Task<List<QuickLinkModel>> GetAllQuickLinksAsync()
        {
            var records = await _context.QuickLinks.Select(x=>new QuickLinkModel()
            {
                Id=x.Id,
                Title=x.Title,
                Url=x.Url,

            }).ToListAsync();

            return records;
        }
    }
}
