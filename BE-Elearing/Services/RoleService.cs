using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class RoleService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public RoleService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }
    }
}
