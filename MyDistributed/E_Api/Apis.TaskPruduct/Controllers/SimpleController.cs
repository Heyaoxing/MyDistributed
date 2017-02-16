using Hangfire;
using Services.Jobs.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apis.TaskPruduct.Controllers
{
    public class SimpleController : ApiController
    {
        [HttpGet]
        public void CreateSimple(string message)
        {
            BackgroundJob.Enqueue<IExample>(x => x.Say(message));
        }
    }
}
