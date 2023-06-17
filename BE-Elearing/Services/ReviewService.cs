using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class ReviewService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ReviewService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }
    }
}
