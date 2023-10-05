using InterraWebBackend.Models;
using InterraWebBackend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterraWebBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageDataController : ControllerBase
    {
        private readonly IHomePageDataRepository _homePageDataRepository;

        public HomePageDataController(IHomePageDataRepository homePageDataRepository)
        {
            _homePageDataRepository = homePageDataRepository;
        }

        [HttpGet("partners")]
        public async Task<IActionResult> GetStrategicpartnersList()
        {
            var records = await _homePageDataRepository.GetPartnerListAsync();
            return Ok(records);
        }

        [HttpPost("send-query")]
        public async Task<IActionResult> PostUserQuery([FromBody] QueryModel userQuery)
        {
            if (userQuery == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                await _homePageDataRepository.AddUserQuery(userQuery);
               

                return Ok("Query submitted successfully.");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., database errors) here
                return StatusCode(500, "An error occurred while processing the request.");
            }

         
           

           

        }
    }
}
