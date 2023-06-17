using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : Controller
    {

        private readonly RoleService _service;
        private readonly IConfiguration _configuration;
        public RoleController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new RoleService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Role> list = _service.GetAll();
            return list.Count == 0 ? BadRequest(new
            {
                status = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                status = "true",
                data = list
            });

        }
    }
}
