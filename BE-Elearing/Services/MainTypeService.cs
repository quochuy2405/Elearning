using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class MainTypeService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public MainTypeService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<MainType> GetAll()
        {
            return _context.MainTypes.ToList();
        }
    }
}
