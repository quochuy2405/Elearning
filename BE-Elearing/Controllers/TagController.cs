using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/tag")]
    [ApiController]
    public class TagController : Controller
    {

        private readonly TagService _service;
        private readonly IConfiguration _configuration;
        public TagController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new TagService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Tag> list = _service.GetAll();
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
