using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterraWebBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuickLinksController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "QuickLinks!";
        }
    }
}
