using System.Configuration;

namespace RabbitConfiguration
{
    public class HostElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name { get => (string)this["name"]; set => this["name"] = value; }

        [ConfigurationProperty("url", IsRequired = true)]
        public string Url { get => (string)this["url"]; set => this["url"] = value; }

        [ConfigurationProperty("credential", IsRequired = true)]
        public CredentialElement Credential => (CredentialElement)base["credential"];
    }
}