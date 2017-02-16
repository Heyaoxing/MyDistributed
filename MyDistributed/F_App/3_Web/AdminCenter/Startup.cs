using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Common.RedisHelper;
using Autofac;
using Services.Jobs.Simple;
using Servers.Config;

[assembly: OwinStartup(typeof(AdminCenter.Startup))]

namespace AdminCenter
{
    public class Startup
    {
        
        //Hangfire 面板配置
        public void Configuration(IAppBuilder app)
        {
            //   GlobalConfiguration.Configuration.UseRedisStorage(RedisUtils.GetHostAndPort()).UseRedisStorage();  //只支持本地搭建

            GlobalConfiguration.Configuration.UseColouredConsoleLogProvider().UseRedisStorage(RedisUtils.GetHostAndPort());  //支持远程搭建
            app.UseHangfireDashboard();
            AutofacConfig.Init();
        }
    }
}
