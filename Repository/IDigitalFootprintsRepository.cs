using InterraWebBackend.Models;

namespace InterraWebBackend.Repository
{
    public interface IDigitalFootprintsRepository
    {
        Task<List<WebinarModel>> GetAllWebinarsAsync();
    }
}
