using System.Web.Mvc;

namespace SoftSupply.Help.Areas.GanSoftPro
{
    public class GenericAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GanSoftPro";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}