using System.Web;
using System.Web.Mvc;

namespace Pcf.Config.WebConfigTransformBuildpack
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
