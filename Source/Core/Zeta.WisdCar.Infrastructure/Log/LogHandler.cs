using Metrics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Infrastructure.Log
{
    public class LogHandler
    {
        //Error Metrics
        private static readonly Meter _errorMetrics = Metric.Meter("Errors", Unit.Requests, TimeUnit.Seconds);

        public static void Debug(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsDebugEnabled)
            {
                log.Debug(message);
            }
        }

        public static void Error(string message)
        {
            _errorMetrics.Mark();

            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsErrorEnabled)
            {
                log.Error(message);
            }
        }

        public static void Error(string message, Exception ex)
        {
            _errorMetrics.Mark();

            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsErrorEnabled)
            {
                log.Error(message, ex);
            }
        }

        public static void Fatal(string message)
        {
            _errorMetrics.Mark();

            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsFatalEnabled)
            {
                log.Fatal(message);
            }
        }

        public static void Fatal(string message, Exception ex)
        {
            _errorMetrics.Mark();

            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsFatalEnabled)
            {
                log.Fatal(message, ex);
            }
        }

        public static void Info(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public static void Warn(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().DeclaringType);
            if (log.IsWarnEnabled)
            {
                log.Warn(message);
            }
        }

    }
}
