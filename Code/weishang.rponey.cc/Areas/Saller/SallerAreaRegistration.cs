using System.Web.Mvc;

namespace weishang.rponey.cc.Areas.Saller
{
    public class SallerAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Saller";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Saller_default",
                "Saller/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}