using InterraWebBackend.Data;
using InterraWebBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Repository
{
    public class ClientFeedbackRepository : IClientFeedbackRepository
    {
        private readonly InterraDBContext _context;

        public ClientFeedbackRepository(InterraDBContext context)
        {
            _context = context;
        }
        public async Task<List<ClientFeedbackModel>> GetAllClientFeedbacksAsync()
        {
            var records = await _context.ClientFeedbacks.Select(x => new ClientFeedbackModel()
            {
                Id = x.Id,
                ClientName = x.ClientName,
                ClientProfile = x.ClientProfile,
                Rating = x.Rating,
                Feedback = x.Feedback,

            }).ToListAsync();

            return records;
        }
        
    
    }
}
