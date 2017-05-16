using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bangazon_MVC_InitialSite.DAL;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class AddProductController : Controller
    {
        readonly IAddProductRepo _addProductRepo;

        public AddProductController(IAddProductRepo addProductRepo)
        {
            _addProductRepo = addProductRepo;
        }

        // GET: AddProduct
        public ActionResult Index()
        {
            var product = new Product();
            return View(product);
        }

        // POST: AddProduct
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Product product)
        {
            try
            {
                //product.CustomerId = 1;
                _addProductRepo.AddProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return Redirect("Shared/Error");
            }
        }
    }
}