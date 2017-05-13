using Bangazon_MVC_InitialSite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class DetailController : Controller
    {
        readonly IProductRepository _productRepository;

        public DetailController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: Detail
        public ActionResult Index(int productId)
        {
            ViewBag.Product = _productRepository.GetProductById(productId);
            return View("Detail");
        }
    }
}