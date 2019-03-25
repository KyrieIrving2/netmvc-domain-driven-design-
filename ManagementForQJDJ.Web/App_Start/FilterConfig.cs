using ManagementForQJDJ.Web.Models;
using System.Web;
using System.Web.Mvc;

namespace ManagementForQJDJ.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new MyErrorByRedisAttribute());
        }
    }
}
