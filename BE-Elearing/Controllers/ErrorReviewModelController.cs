using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/error_review")]
    [ApiController]
    public class ErrorReviewModelController : Controller
    {
        private readonly ErrorReviewModelService _service;
        private readonly IConfiguration _configuration;
        public ErrorReviewModelController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ErrorReviewModelService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<ErrorReviewModel> list = _service.GetAll();
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
