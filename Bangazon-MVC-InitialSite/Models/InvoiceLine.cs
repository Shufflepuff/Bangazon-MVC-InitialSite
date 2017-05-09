using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class InvoiceLine
    {
        public int OrderLineId { get; set; }

        public int InvoiceId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}