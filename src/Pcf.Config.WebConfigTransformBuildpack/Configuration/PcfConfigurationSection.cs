using System.Configuration;

namespace Pcf.Config.WebConfigTransformBuildpack.Configuration
{
    public class PcfConfigurationSection : ConfigurationSection
    {
        private PcfConfigurationSection() { }

        [ConfigurationProperty("organization")]
        public PcfOrganizationElement Organization
        {
            get { return (PcfOrganizationElement)this["organization"]; }
        }
    }
}