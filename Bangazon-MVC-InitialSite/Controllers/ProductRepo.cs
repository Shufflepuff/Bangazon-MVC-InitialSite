using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.Controllers
{
    public class ProductRepo : IProductRepo
    {
        public Product GetProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}