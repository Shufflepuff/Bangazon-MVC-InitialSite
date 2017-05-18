using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bangazon_MVC_InitialSite.DAL;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;
        readonly IProductTypeRepo _productTypeRespository;
        readonly ICustomerRepo _customerRepository;

        public ProductController(IProductRepository productRepository, IProductTypeRepo productTypeRepository, ICustomerRepo customerRepository)
        {
            _productRepository = productRepository;
            _productTypeRespository = productTypeRepository;
            _customerRepository = customerRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            //int id = int.Parse(Request.QueryString["productTypeId"]);
            //ViewBag.Products = _productRepository.GetProductsByProductTypeId(id);
            //var cookie = Request.Cookies.AllKeys.Contains("UserCookies");
            ViewBag.Products = _productRepository.GetProducts();
            return View("Products");
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var customers = _customerRepository.GetCustomers();
            var productTypes = _productTypeRespository.GetAllProductTypes();

            var viewModel = new CreateProductViewModel
            {
                Customers = customers.Select(x => new SelectListItem { Text = x.Name, Value = x.CustomerId.ToString()}).ToList(),
                ProductTypes = productTypes.Select(x => new SelectListItem { Text = x.Type, Value = x.ProductTypeId.ToString() }).ToList()
            };


            return View("Create", viewModel);
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateProductViewModel product)
        {
            try
            {
                var prod = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description
                };

                prod.ProductType = _productTypeRespository.GetProductTypeById(product.ProductTypeId);
                prod.Customer = _customerRepository.GetCustomerById(product.CustomerId);
                
                _productRepository.AddProduct(prod);
                return RedirectToAction("Index");
            }
            catch
            {
                return Redirect("../Shared/Error");
            }
        }
    }
}