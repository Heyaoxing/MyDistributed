using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Servers.JobServer
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            HostFactory.Run(x =>
            {
                x.Service<Master>(s =>
                {
                    s.ConstructUsing(name => new Master());
                    s.WhenStarted(tc => tc.Start());             
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("任务调度服务端");
                x.SetDisplayName("Job执行服务端");
                x.SetServiceName("Job执行服务端");
            });
        }
    }
}
