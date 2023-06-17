using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/main_type")]
    [ApiController]
    public class MainTypeController : Controller
    {
        private readonly MainTypeService _service;
        private readonly IConfiguration _configuration;
        public MainTypeController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new MainTypeService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<MainType> list = _service.GetAll();
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
