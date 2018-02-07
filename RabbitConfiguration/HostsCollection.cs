using System.Configuration;

namespace RabbitConfiguration
{

    [ConfigurationCollection(typeof(HostElement), AddItemName = "host")]
    public class HostsCollection : ConfigurationElementCollection
    {
        [ConfigurationProperty("defaultHost", Options = ConfigurationPropertyOptions.None)]
        public string DefaultHostName => (string)base["defaultHost"];

        public HostElement DefaultHost
        {
            get
            {
                var hostname = DefaultHostName;
                return this[hostname];
            }
        }
        protected override ConfigurationElement CreateNewElement()
        {
            return new HostElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HostElement)element).Name;
        }

        public HostElement this[int index]
        {
            get => (HostElement)BaseGet(index);
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(value);
            }
        }
        public new HostElement this[string name]
        {
            get => (HostElement)BaseGet(name);
        }

    }
}