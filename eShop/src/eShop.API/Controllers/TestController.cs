using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> TestActionAsync()
        {
            return Ok("Qalesiz! Xush kelibsiz, Qiyqiriqqa!");
        }
    }
}
