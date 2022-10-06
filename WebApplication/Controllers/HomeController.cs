using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var home = new Home();
            return Ok(home);
        }
    }
}