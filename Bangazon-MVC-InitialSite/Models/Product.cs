using System;
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
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ProductTypeId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}