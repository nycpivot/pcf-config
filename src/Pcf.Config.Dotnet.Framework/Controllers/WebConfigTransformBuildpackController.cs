using System.Configuration;
using System.Web.Mvc;

namespace Pcf.Config.Dotnet.Framework.Controllers
{
    public class WebConfigTransformBuildpackController : Controller
    {
        // GET: WebConfigTransformBuildpack
        public ActionResult Index()
        {
            ViewBag.Name = ConfigurationManager.AppSettings["name"];
            ViewBag.Environment = ConfigurationManager.AppSettings["environment"];

            ViewBag.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            return View();
        }
    }
}