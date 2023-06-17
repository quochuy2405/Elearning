using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class ChapterService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ChapterService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Chapter> GetAll()
        {
            return _context.Chapters.ToList();
        }
    }
}
