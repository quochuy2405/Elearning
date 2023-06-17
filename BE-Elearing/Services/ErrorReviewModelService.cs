using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class ErrorReviewModelService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ErrorReviewModelService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<ErrorReviewModel> GetAll()
        {
            return _context.ErrorReviewModels.ToList();
        }
    }
}
