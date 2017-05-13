using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int AccountNumber { get; set; }

        public virtual Customer Customer { get; set; }
    }
}