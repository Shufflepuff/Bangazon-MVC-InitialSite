using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class InvoiceLine
    {
        [Key]
        public int InvoiceLineId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public virtual IEnumerable<Product> products { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}