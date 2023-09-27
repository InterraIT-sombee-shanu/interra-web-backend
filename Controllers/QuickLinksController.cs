using InterraWebBackend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuickLinksController : ControllerBase
    {
        private readonly IQuickLinkRepository _quickLinkRepository;
        public QuickLinksController(IQuickLinkRepository quickLinkRepository)
        {
            _quickLinkRepository = quickLinkRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var quickLinks = await _quickLinkRepository.GetAllQuickLinksAsync();
            return Ok(quickLinks);
        }
    }
}
