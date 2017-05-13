using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
=======
using Bangazon_MVC_InitialSite.DAL;
>>>>>>> c41540bd959a8840628c5071d5df305891ec84f7

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductController : Controller
    {
<<<<<<< HEAD
        // GET: Product
        public ActionResult Index()
        {
            return View();
=======
        readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            ViewBag.Products = _productRepository.GetProducts();
            return View("Products");
>>>>>>> c41540bd959a8840628c5071d5df305891ec84f7
        }
    }
}