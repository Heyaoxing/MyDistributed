using Autofac;
using Hangfire;
using Services.Jobs.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers.Config
{
    public class AutofacConfig
    {
        public static void Init()
        {
            GlobalConfiguration.Configuration.UseAutofacActivator(ConfigureContainer());
        }
        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            RegisterApplicationComponents(builder);
            return builder.Build();
        }

        private static void RegisterApplicationComponents(ContainerBuilder builder)
        {
            builder.RegisterType<Example>().As<IExample>().InstancePerLifetimeScope();
        }
    }
}
