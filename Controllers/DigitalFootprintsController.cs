using InterraWebBackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DigitalFootprintsController : ControllerBase
    {

        private readonly IDigitalFootprintsRepository _digitalFootprintsRepository;

        public DigitalFootprintsController(IDigitalFootprintsRepository digitalFootprintsRepository)
        {
            _digitalFootprintsRepository = digitalFootprintsRepository;
        }

        [HttpGet("webinars")]
        public async Task<IActionResult> GetAllWebinars()
        {
            var webinars = await _digitalFootprintsRepository.GetAllWebinarsAsync();
            return Ok(webinars);
        }

    }
}
