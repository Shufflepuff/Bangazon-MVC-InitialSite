using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Controllers
{
        [RoutePrefix("payment")]
        public class PaymentController : Controller
        {
            // GET: Payment
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult ListPayment(string Type, int howManyCustomerHas = 1)
            {
                ViewBag.Payment = "Payment Option" + Type;
                ViewBag.HowMany = howManyCustomerHas;
                return View();
            }
        }
    }
