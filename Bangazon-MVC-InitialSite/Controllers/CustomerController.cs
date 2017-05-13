using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bangazon_MVC_InitialSite.DAL;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class CustomerController : Controller
    {
        readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        // GET: Customer
        public PartialViewResult CustomerDropDownPartial()
        {
           IEnumerable<Customer> customers =  _customerRepo.GetCustomers();

            var dropdownData = customers
                .Select(c => new SelectListItem()
                {
                    Text = c.Name, //Need to apply the correct text field here
                    Value = c.CustomerId.ToString() //Need to apply the correct value field here
                })
                .ToList();

            var model = new CustomerDropDown();
            model.CustomerDropDownData = dropdownData;
            model.SelectedId = 3;

            return PartialView("~/Views/Customer/CustomerDropDownPartial.cshtml",model);
        }

        // GET: Customer
        public PartialViewResult CustomerDropDownPartial(int id)
        {
            IEnumerable<Customer> customers = _customerRepo.GetCustomers();

            var dropdownData = customers
                .Select(c => new SelectListItem()
                {
                    Text = c.Name, //Need to apply the correct text field here
                    Value = c.CustomerId.ToString() //Need to apply the correct value field here
                })
                .ToList();

            var model = new CustomerDropDown();
            model.CustomerDropDownData = dropdownData;
            model.SelectedId = 3;

            return PartialView("~/Views/Customer/CustomerDropDownPartial.cshtml", model);
        }
    } 
}