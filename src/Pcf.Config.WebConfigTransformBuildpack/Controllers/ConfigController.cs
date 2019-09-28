using Pcf.Config.WebConfigTransformBuildpack.Configuration;
using System.Configuration;
using System.ServiceModel.Configuration;
using System.Web.Mvc;

namespace Pcf.Config.WebConfigTransformBuildpack.Controllers
{
    public class ConfigController : Controller
    {
        public ActionResult Index()
        {
            //<appsettings>
            ViewBag.Name = ConfigurationManager.AppSettings["name"];
            ViewBag.Environment = ConfigurationManager.AppSettings["environment"];


            //<connectionStrings>
            ViewBag.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;


            //<services.serviceModel>
            var clientSection = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");

            var endpoint = clientSection.Endpoints[0];

            ViewBag.Address = endpoint.Address.AbsolutePath;
            ViewBag.Binding = endpoint.Binding;
            ViewBag.Contract = endpoint.Contract;


            //<pcf>
            var pcfSection = (PcfConfigurationSection)ConfigurationManager.GetSection("pcf");

            ViewBag.OrganizationName = pcfSection.Organization.Name;
            ViewBag.SpaceName = pcfSection.Organization.Space.Name;
            ViewBag.DiskQuota = pcfSection.Organization.Quota.Disk;
            ViewBag.RamQuota = pcfSection.Organization.Quota.Ram;
            ViewBag.AppName = pcfSection.Organization.Space.App.Name;
            ViewBag.ServiceName = pcfSection.Organization.Space.Service.Name;

            return View();
        }
    }
}