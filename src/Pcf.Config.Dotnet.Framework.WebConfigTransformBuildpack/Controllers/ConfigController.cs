using System.Configuration;
using System.Web.Mvc;

namespace Pcf.Config.Dotnet.Framework.WebConfigTransformBuildpack.Controllers
{
    public class ConfigController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = ConfigurationManager.AppSettings["name"];
            ViewBag.Environment = ConfigurationManager.AppSettings["environment"];

            ViewBag.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            return View();
        }
    }
}