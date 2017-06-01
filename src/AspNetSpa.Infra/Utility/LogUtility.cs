using System;
using System.Collections.Generic;
using System.Linq;
using AspNetSpa.Infra.Extension;

namespace AspNetSpa.Infra.Utility
{
    public static class LogUtility
    {
        // logger
        public static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Log an error message
        /// </summary>
        /// <param name="error">Error message</param>
        public static void LogErrorMsg(String error)
        {
            Logger.Error(error);
        }

        /// <summary>
        /// Log a set of errors
        /// </summary>
        /// <param name="errors">String Enumerable</param>
        public static void LogErrorMsg(IEnumerable<String> errors)
        {
            if (errors != null)
            {
                foreach (var error in errors)
                {
                    Logger.Error(
                        String.Format(error));
                }
            }
        }


        /// <summary>
        /// Log the errors from the exception and inner exceptions  
        /// </summary>
        /// <param name="exp">Exception</param>
        public static void LogErrorMsg(Exception exp)
        {
            var exMsgs = exp.FlattenHierarchy().Select(x => x.Message);
            LogErrorMsg(exMsgs);
        }
    }
}