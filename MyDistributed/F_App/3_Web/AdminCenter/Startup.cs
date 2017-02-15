using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Common.RedisHelper;

[assembly: OwinStartup(typeof(AdminCenter.Startup))]

namespace AdminCenter
{
    public class Startup
    {
        //Hangfire 面板配置
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseRedisStorage(RedisUtils.GetHostAndPort()).UseRedisStorage(); ;
            app.UseHangfireDashboard();
        }
    }
}
