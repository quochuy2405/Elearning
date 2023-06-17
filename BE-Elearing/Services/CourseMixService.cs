using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class CourseMixService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public CourseMixService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<CourseMix> GetAll()
        {
            return _context.CourseMixs.ToList();
        }
    }
}
