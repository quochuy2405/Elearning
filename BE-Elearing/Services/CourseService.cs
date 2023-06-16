using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class CourseService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public CourseService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Course> GetCourses()
        {
            return new List<Course>() { new Course { ID = 1, CourseTypeID = 1 } } ;
        }
    }
}
