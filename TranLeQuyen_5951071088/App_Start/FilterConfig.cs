using System.Web;
using System.Web.Mvc;

namespace TranLeQuyen_5951071088
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
