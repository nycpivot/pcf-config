using System.Configuration;

namespace Pcf.Config.WebConfigTransformBuildpack.Configuration
{
    public class PcfOrganizationElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "")]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("space")]
        public PcfSpaceElement Space
        {
            get { return (PcfSpaceElement)this["space"]; }
        }

        [ConfigurationProperty("quota")]
        public PcfQuotaElement Quota
        {
            get { return (PcfQuotaElement)this["quota"]; }
        }
    }
}