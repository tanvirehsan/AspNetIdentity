namespace Tanehs.AspNetMVC.Identity
{
    using System.Web.Mvc;

    public class IdentityAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Identity";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Identity_default",
                "Identity/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}