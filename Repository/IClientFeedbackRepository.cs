using InterraWebBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Repository
{
    public interface IClientFeedbackRepository
    {
         Task<List<ClientFeedbackModel>> GetAllClientFeedbacksAsync();
    }
}
