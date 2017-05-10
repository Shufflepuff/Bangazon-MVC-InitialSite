using Bangazon_MVC_InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bangazon_MVC_InitialSite.DAL
{
    public class AddProductRepo : IAddProductRepo
    {
        private readonly AppContext _context;

        public AddProductRepo(AppContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}