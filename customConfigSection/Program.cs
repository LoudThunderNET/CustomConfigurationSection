using RabbitConfiguration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customConfigSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitCfg = ConfigurationManager.GetSection("rabbit") as Rabbit;
            Console.WriteLine(rabbitCfg.Hosts.DefaultHostName);
            foreach (HostElement host in rabbitCfg.Hosts)
            {
                Console.WriteLine($"{host.Name} {host.Url}");
            }
        }
    }
}
