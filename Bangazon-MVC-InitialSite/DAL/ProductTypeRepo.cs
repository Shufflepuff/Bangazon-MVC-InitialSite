using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.DAL
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        readonly AppContext _context;

        public ProductTypeRepo(AppContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductType> GetAllProductTypes()
        {
            return _context.ProductTypes;
        }

        public ProductType GetProductTypeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}