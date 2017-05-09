using System.Web;
using System.Web.Mvc;

namespace Bangazon_MVC_InitialSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
