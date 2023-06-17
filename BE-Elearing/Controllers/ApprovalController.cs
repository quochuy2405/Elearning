using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/approval")]
    [ApiController]
    public class ApprovalController : Controller
    {
        private readonly ApprovalService _service;
        private readonly IConfiguration _configuration;
        public ApprovalController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ApprovalService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCouses()
        {
            List<Approval> list = _service.GetAll();
            return list.Count == 0 ? BadRequest(new
            {
                status = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                status = "true",
                data= list
            });

        }
    }
}
