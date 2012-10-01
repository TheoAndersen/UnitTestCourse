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
        // this static wrapper is not used anymore, as we use the abstraction already included in the Log4Net api

        //private static ILog logger;

        //private static void Initialize()
        //{
        //    // Only configure log4net once per process   
        //    if (!LogManager.GetRepository().Configured)
        //    {
        //        // Configure log4net.
        //        log4net.Config.XmlConfigurator.Configure();
        //    }

        //    if (logger == null)
        //    {
        //        logger = log4net.LogManager.GetLogger("RollingFile");
        //    }
        //}

        //public static ILog Initialize()
        //{
        //    // Only configure log4net once per process   
        //    if (!LogManager.GetRepository().Configured)
        //    {
        //        // Configure log4net.
        //        log4net.Config.XmlConfigurator.Configure();
        //    }

        //    return log4net.LogManager.GetLogger("RollingFile");
        //}

        //public static void LogInfo(string info)
        //{
        //    Initialize();
        //    logger.Info(info);
        //}
    }
}
