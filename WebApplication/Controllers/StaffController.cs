using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplicationAPI.Models;
using EF_CONFIG.Model;


namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StaffController : ControllerBase
    {
        private readonly NeedleSupplierDataContext _supplierDataContext;
        public StaffController()
        {
            _supplierDataContext = new NeedleSupplierDataContext();
        }

        [HttpGet("{id}")]
        public IActionResult Id(int id)
        {
            var staff = new Staff(_supplierDataContext, id);
            if (staff != null)
            {
                return Ok(staff);

            }
            else
            {
                return BadRequest();
            }
        }

    }
}