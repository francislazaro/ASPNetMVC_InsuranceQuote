using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC_InsuranceQuote
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
