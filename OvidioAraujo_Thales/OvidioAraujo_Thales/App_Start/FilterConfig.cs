using System.Web;
using System.Web.Mvc;

namespace OvidioAraujo_Thales
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
