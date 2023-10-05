using InterraWebBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Repository
{
    public interface IHomePageDataRepository
    {
        Task<List<StrategicPartnerModel>> GetPartnerListAsync();

        Task AddUserQuery(QueryModel query);
    }
}
