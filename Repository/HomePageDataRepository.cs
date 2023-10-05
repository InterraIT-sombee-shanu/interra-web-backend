using InterraWebBackend.Data;
using InterraWebBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InterraWebBackend.Repository
{
    public class HomePageDataRepository : IHomePageDataRepository
    {
        private readonly InterraDBContext _context;

        public HomePageDataRepository(InterraDBContext context)
        {
            _context = context;
        }

        public async Task AddUserQuery(QueryModel userQuery)
        {
            // Add the userQuery to the DbSet and save changes to the database
            var query = new Query()
            {
                Name = userQuery.Name,
                Email = userQuery.Email,
                Message = userQuery.Message,
                Company = userQuery.Company,
            };
            _context.Queries.Add(query);
            await _context.SaveChangesAsync();
        }

        public Task<List<StrategicPartnerModel>> GetPartnerListAsync()
        {
            var records = _context.StrategicPartners.Select(x=> new StrategicPartnerModel {
                Id = x.Id, 
                Name = x.Name,
                Logo = x.Logo,
                URL = x.URL,
            }).ToListAsync();
            return records;
        }
    }
}
