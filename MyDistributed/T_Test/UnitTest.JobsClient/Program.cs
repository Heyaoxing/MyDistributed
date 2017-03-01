using Common.RedisHelper;
using Hangfire;
using Hangfire.Server;
using Services.Jobs.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.JobsClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration
               .UseColouredConsoleLogProvider()
               .UseRedisStorage(RedisUtils.GetHostAndPort());
            //然后需要推送的时候，调用下面的方法即可
            BackgroundJob.Enqueue<IExample>(x => x.Say("测试"));
        }
    }
}
