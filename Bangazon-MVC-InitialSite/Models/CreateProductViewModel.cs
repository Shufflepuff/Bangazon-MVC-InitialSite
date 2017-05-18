using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Models
{
    public class CreateProductViewModel
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int ProductTypeId { get; set; }

        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> ProductTypes { get; set; }
    }
}