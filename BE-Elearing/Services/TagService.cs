using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class TagService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public TagService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }
    }
}
