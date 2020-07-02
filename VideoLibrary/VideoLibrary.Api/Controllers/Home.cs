using Microsoft.AspNetCore.Mvc;

namespace VideoLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home: ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Test from controller";
        }
    }
}