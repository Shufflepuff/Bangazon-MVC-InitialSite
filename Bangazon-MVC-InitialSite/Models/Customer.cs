using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class Customer : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public string Phone { get; set; }

        public virtual IEnumerable<Payment> CustomerPayments { get; set; }
        public virtual IEnumerable<Invoice> Invoices { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}