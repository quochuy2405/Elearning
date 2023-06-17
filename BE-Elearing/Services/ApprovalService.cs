using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class ApprovalService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ApprovalService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Approval> GetAll()
        {
            return _context.Approvals.ToList();
        }
    }
}
