using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class ProductType
    {
        public int TypeId { get; set; }
        public string Type { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

    }
}