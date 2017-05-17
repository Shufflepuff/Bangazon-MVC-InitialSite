using Bangazon_MVC_InitialSite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class PaymentRepository : IPaymentRepo
    {
        private readonly AppContext _context;

        public PaymentRepository(AppContext context)
        {
            _context = context;
        }
        public IEnumerable<Payment> GetPayments()
        {
            return _context.Payments;
        }
    }

}
