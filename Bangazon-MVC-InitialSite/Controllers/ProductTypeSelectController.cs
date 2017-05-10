using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductTypeSelectController : Controller
    {
        // GET: ProductTypeSelect
        public ActionResult Index()
        {
            return View("ProductTypeSelectView");
        }
    }
}