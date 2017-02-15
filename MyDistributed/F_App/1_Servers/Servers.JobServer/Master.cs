using Common.Logging;
using Common.RedisHelper;
using Common.Tools;
using Hangfire;
using Hangfire.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers.JobServer
{
    public class Master
    {

        private BackgroundJobServer _server = null;
        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            Log.Info("启动服务");
            try
            {
                JobStorage.Current = new RedisStorage(RedisUtils.GetHostAndPort());
                string serverName = LocalhostHelper.GetInternalIP();
                _server = new BackgroundJobServer(new BackgroundJobServerOptions()
                {
                    ServerName = serverName,
                    WorkerCount = Math.Max(Environment.ProcessorCount, 20)
                });
                _server.Start();
            }
            catch (Exception ex)
            {
                Log.Info(ex.Message);
            }

        }
        /// <summary>
        /// 关闭
        /// </summary>
        public void Stop()
        {
            try
            {
                if (_server != null)
                    _server.Dispose();
            }
            catch (Exception ex)
            {
                Log.Info(ex.Message);
            }
        }
    }
}
