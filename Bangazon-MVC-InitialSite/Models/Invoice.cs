using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public virtual IEnumerable<InvoiceLine> InvoiceLines { get; set; }
    }
}