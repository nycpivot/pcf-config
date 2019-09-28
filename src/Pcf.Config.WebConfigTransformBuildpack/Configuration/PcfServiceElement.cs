
using System.Configuration;

namespace Pcf.Config.WebConfigTransformBuildpack.Configuration
{
    public class PcfServiceElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "")]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }
    }
}