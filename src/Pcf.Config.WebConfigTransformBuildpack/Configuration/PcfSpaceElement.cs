using System.Configuration;

namespace Pcf.Config.WebConfigTransformBuildpack.Configuration
{
    public class PcfSpaceElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "")]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("app")]
        public PcfAppElement App
        {
            get { return (PcfAppElement)this["app"]; }
        }

        [ConfigurationProperty("service")]
        public PcfServiceElement Service
        {
            get { return (PcfServiceElement)this["service"]; }
        }
    }
}