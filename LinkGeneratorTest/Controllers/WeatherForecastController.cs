using Microsoft.AspNetCore.Mvc;

namespace LinkGeneratorTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Microsoft.AspNetCore.Routing.LinkGenerator _linkGenerator;

        public WeatherForecastController(Microsoft.AspNetCore.Routing.LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }

        [HttpGet]
        public string? Get()
        {
            return _linkGenerator.GetUriByAction("Get", "WeatherForecast", null, null, new("localhost"));
        }
    }
}