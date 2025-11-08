using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldModel;

namespace CSUN584Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(WeatherContext context) : ControllerBase
    {
        [HttpPost]
        [Route("/countries")]
        public async Task<ActionResult> PostCountries()
        {
            var countries = await context.Countries.ToDictionaryAsync(c => c.Name, StringComparer.OrdinalIgnoreCase);
            await context.SaveChangesAsync();


            return Ok();
        }

        [HttpPost]
        [Route("/cities")]
        public async Task<ActionResult> PostCities()
        {
           
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
