using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bangazon_MVC_InitialSite.DAL;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var cookie = Request.Cookies.AllKeys.("UserCookies");
            ViewBag.Products = _productRepository.GetProducts();
            return View("Products");
        }
    }
}