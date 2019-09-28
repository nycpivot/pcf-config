using System.Configuration;

namespace Pcf.Config.WebConfigTransformBuildpack.Configuration
{
    public class PcfQuotaElement : ConfigurationElement
    {
        [ConfigurationProperty("disk", DefaultValue = "")]
        public string Disk
        {
            get { return (string)this["disk"]; }
            set { this["disk"] = value; }
        }

        [ConfigurationProperty("ram", DefaultValue = "")]
        public string Ram
        {
            get { return (string)this["ram"]; }
            set { this["ram"] = value; }
        }
    }
}