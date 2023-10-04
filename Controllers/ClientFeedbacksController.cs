using InterraWebBackend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientFeedbacksController : ControllerBase
    {
        private readonly IClientFeedbackRepository _clientFeedbackRepository;

        public ClientFeedbacksController(IClientFeedbackRepository clientFeedbackRepository)
        {
            _clientFeedbackRepository = clientFeedbackRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientFeedbacks()
        {
            var feedbacks = await _clientFeedbackRepository.GetAllClientFeedbacksAsync();
            return Ok(feedbacks);
        }


    }
}
