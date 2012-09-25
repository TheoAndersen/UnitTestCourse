using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace _2___AnnoyingDependencies
{
    public class Logger
    {
        private static ILog logger;

        private static void Initialize()
        {
            // Only configure log4net once per process   
            if (!LogManager.GetRepository().Configured)
            {
                // Configure log4net.
                log4net.Config.XmlConfigurator.Configure();
            }

            if (logger == null)
            {
                logger = log4net.LogManager.GetLogger("RollingFile");
            }
        }

        public static void LogInfo(string info)
        {
            Initialize();
            logger.Info(info);
        }
    }
}
