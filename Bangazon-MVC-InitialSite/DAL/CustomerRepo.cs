using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.DAL
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppContext _context;

        public CustomerRepo(AppContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }
    }
}