using Bangazon_MVC_InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_MVC_InitialSite.DAL
{
    public interface IProductTypeRepo
    {
        IEnumerable<ProductType> GetAllProductTypes();
        ProductType GetProductTypeById(int id);
    }
}
