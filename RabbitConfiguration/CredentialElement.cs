using System.Configuration;

namespace RabbitConfiguration
{
    public class CredentialElement : ConfigurationElement
    {
        [ConfigurationProperty("username", IsRequired = true)]
        public string UserName => (string)this["username"];

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password => (string)this["password"];
    }
}