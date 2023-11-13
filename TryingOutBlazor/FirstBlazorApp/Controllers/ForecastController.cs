using FirstBlazorApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstBlazorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController: ControllerBase
    {
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetAction([FromServices] WeatherForecastService service, DateOnly startDate)
        {
            var svc = new WeatherForecastService();
            return new OkObjectResult(await svc.GetForecastAsync(startDate));
        }
    }
}
