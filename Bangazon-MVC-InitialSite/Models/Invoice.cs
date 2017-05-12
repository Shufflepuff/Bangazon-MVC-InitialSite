using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int paymentId { get; set; }

        public virtual IEnumerable<InvoiceLine> InvoiceLines { get; set; }
        public virtual Customer Customer { get; set; }
    }
}