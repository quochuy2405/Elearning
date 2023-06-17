using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/chapter")]
    [ApiController]
    public class ChapterController : Controller
    {
        private readonly ChapterService _service;
        private readonly IConfiguration _configuration;
        public ChapterController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ChapterService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Chapter> list = _service.GetAll();
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
