using System.Web.Mvc;

namespace Pcf.Config.Dotnet.Framework.WebConfigTransformBuildpack
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}