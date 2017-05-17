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
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Product = _productRepository.GetProductById(1);
            return View("Detail");
        }
    }
}