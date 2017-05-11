using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.DAL
{
    public class ProductRepository : IProductRepository
    {
        readonly AppContext _context;

        public ProductRepository(AppContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}