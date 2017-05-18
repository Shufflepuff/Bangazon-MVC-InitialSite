using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.DAL
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(int id);
    }
}