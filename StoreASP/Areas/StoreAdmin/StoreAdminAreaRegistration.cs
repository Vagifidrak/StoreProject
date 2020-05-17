using System.Web.Mvc;

namespace StoreASP.Areas.StoreAdmin
{
    public class StoreAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StoreAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StoreAdmin_default",
                "StoreAdmin/{controller}/{action}/{id}",
                new { action = "Index", Controller="Home", id = UrlParameter.Optional },
                new [] { "StoreASP.Areas.StoreAdmin.Controllers" }
            );
        }
    }
}