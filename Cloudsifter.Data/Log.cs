using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Cloudsifter.Data
{
    public static class Log
    {
        private static Loggly.Logger Logger;
        private static string GetCallerTwoStepsBack()
        {
            // we go two steps back because this was called by the log method, and we really want
            // the method that called _that_ log method... :)

            // get call stack
            StackTrace stackTrace = new StackTrace();

            // get calling method name
            return stackTrace.GetFrame(2).GetMethod().Name;
        }

        private static string FormatMessage(string message, string caller)
        {
            return caller + ":" + message;
        }

        private static void EnsureLogger()
        {
            Loggly.LogglyConfiguration.Configure(c => c.AuthenticateWith("stratospheres", "myloggly22"));

            if (Logger == null)
                Logger = new Loggly.Logger("55920130-2c1b-47e9-9391-9d07466803ed");
        }

        public static void LogError(string message, Exception exception)
        {
            EnsureLogger();
            Logger.LogError(FormatMessage(message, GetCallerTwoStepsBack()), exception);
        }

        public static void LogError(string message, Exception exception, IDictionary<string, object> data)
        {
            EnsureLogger();
            Logger.LogError(FormatMessage(message, GetCallerTwoStepsBack()), exception, data);
        }

        public static void LogWarning(string message)
        {
            EnsureLogger();
            Logger.LogWarning(FormatMessage(message, GetCallerTwoStepsBack()));
        }

        public static void LogWarning(string message, IDictionary<string, object> data)
        {
            EnsureLogger();
            Logger.LogWarning(FormatMessage(message, GetCallerTwoStepsBack()), data);
        }

        public static void LogInfo(string message)
        {
            EnsureLogger();
            Logger.LogInfo(FormatMessage(message, GetCallerTwoStepsBack()));
        }

        public static void LogInfo(string message, IDictionary<string, object> data)
        {
            EnsureLogger();
            Logger.LogInfo(FormatMessage(message, GetCallerTwoStepsBack()), data);
        }
    }
}
