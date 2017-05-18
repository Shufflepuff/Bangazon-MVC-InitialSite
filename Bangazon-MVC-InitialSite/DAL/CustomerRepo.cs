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

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }
    }
}