using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitConfiguration
{
    public class Rabbit: ConfigurationSection
    {
        [ConfigurationProperty("hosts")]
        public HostsCollection Hosts => (HostsCollection)base["hosts"];
    }
}
