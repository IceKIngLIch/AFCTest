using Microsoft.AspNetCore.Mvc;

namespace AFC.Api
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "test";
        }
    }
}
