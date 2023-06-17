using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class UserService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public UserService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }

}
