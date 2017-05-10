using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class ProductType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

    }
}