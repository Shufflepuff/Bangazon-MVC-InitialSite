using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Models
{
    public class CustomerDropDown
    {
        public IEnumerable<SelectListItem> CustomerDropDownData { get; set; }
        //Might not be an int, but just an example
        public int SelectedId { get; set; }
    }
}