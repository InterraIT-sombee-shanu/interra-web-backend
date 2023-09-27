using InterraWebBackend.Data;
using InterraWebBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Repository
{
    public class DigitalFootprintsRepository : IDigitalFootprintsRepository
    {
        private readonly InterraDBContext _context;

        public DigitalFootprintsRepository(InterraDBContext context)
        {
            _context = context;
        }

        public async Task<List<WebinarModel>> GetAllWebinarsAsync()
        {
            var records = await _context.Webinars.Select(x => new WebinarModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ThumbnailUrl = x.ThumbnailUrl,
                Url = x.Url,

            }).ToListAsync();

            return records;
        }

    }
}
