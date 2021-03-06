﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bangazon_MVC_InitialSite.Models;

namespace Bangazon_MVC_InitialSite.DAL
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        IEnumerable<Product> GetProductsByProductTypeId(int productTypeId);

        void AddProduct(Product product);
    }
}
