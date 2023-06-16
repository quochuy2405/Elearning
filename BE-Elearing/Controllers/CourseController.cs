using BE_Elearing.Access;
using BE_Elearing.Models;
using BE_Elearing.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Elearing.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService _service;
        private readonly IConfiguration _configuration;
        public CourseController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new CourseService(configuration, context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCouses()
        {
            List<Course> courses = _service.GetCourses();
            return courses.Count == 0 ? BadRequest(new
            {
                status = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                status = "true",
                courses
            });

        }
    }
}
