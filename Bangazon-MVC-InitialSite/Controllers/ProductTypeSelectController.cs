using Bangazon_MVC_InitialSite.DAL;
using Bangazon_MVC_InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductTypeSelectController : Controller
    {
        readonly IProductTypeRepo _productTypeRepo;

        public ProductTypeSelectController(IProductTypeRepo productTypeRepo)
        {
            _productTypeRepo = productTypeRepo;
        }

        // GET: ProductTypeSelect
        public ActionResult Index()
        {
            ViewBag.Types = _productTypeRepo.GetAllProductTypes();
            return View("ProductTypeSelectView");
        }
    }
}