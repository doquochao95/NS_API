using WebApplicationNS.Models;
using System.Web.Http;

namespace WebApplicationAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("Home")]
        [Route("")]
        public IHttpActionResult home()
        {
            Home home = new Home();
            return Json(home);
        }
    }
}