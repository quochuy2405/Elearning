using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/learning")]
    [ApiController]
    public class LearningController : Controller
    {
        private readonly LearningService _service;
        private readonly IConfiguration _configuration;
        public LearningController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new LearningService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Learning> list = _service.GetAll();
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
