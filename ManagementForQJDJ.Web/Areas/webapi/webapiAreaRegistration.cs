using System.Web.Mvc;

namespace ManagementForQJDJ.Web.Areas.webapi
{
    public class webapiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "webapi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "webapi_default",
                "webapi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}