using WebApplicationNS.Models;
using System.Web.Http;

namespace WebApplicationNS.Controllers
{
    public class StaffController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getstaff(int id)
        {
            Staff Resp = new Staff(id);
            return Json(Resp);
        }
    }
}