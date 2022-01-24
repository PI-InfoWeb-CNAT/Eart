using System.Web.Mvc;

namespace Eart.Areas.Postagens
{
    public class PostagensAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Postagens";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Postagens_default",
                "Postagens/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}