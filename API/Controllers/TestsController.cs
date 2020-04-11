using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class TestsController : ControllerBase {
        [HttpGet]
        public string GetTest()
        {
            return "this is a test man";
        } 
    }
}