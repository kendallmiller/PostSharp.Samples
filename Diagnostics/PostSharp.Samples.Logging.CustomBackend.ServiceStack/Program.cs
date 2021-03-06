﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Samples.Logging.BusinessLogic;
using ServiceStack.Logging;

[assembly: Log( AttributePriority = 0 )]
[assembly: Log(AttributePriority = 1, AttributeExclude = true, AttributeTargetTypes = "PostSharp.Samples.Logging.CustomBackend.ServiceStack.*")]

namespace PostSharp.Samples.Logging.CustomBackend.ServiceStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure PostSharp Logging to use ServiceStack.
            LoggingServices.DefaultBackend = new ServiceStackLoggingBackend();

            // Configure ServiceStack to output logs to the console.
            LogManager.LogFactory = new ConsoleLogFactory();

            // Simulate some business logic.
            QueueProcessor.ProcessQueue(@".\Private$\SyncRequestQueue");
        }
    }
}
