using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class PaymentService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public PaymentService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Payment> GetAll()
        {
            return _context.Payments.ToList();
        }
    }
}
