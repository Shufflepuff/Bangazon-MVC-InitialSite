﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Product> InvoiceLines { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}