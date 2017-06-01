using System;
using System.Runtime.CompilerServices;
using NLog;

namespace AspNetSpa.Infra.Extension
{
    /// <summary>
    /// NLog Extensions
    /// </summary>
    public static class NLogExtensions
    {
        /// <summary>
        /// Trace Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void TraceMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Trace, filePath, memberName, lineNumber, msg);
        }
        /// <summary>
        /// Info Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void InfoMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Info, filePath, memberName, lineNumber, msg);
        }
        /// <summary>
        /// Debug Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void DebugMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Debug, filePath, memberName, lineNumber, msg);
        }
        /// <summary>
        /// Error Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void WarnMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Warn, filePath, memberName, lineNumber, msg);
        }
        /// <summary>
        /// Error Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void ErrorMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Error, filePath, memberName, lineNumber, msg);
        }
        /// <summary>
        /// Error Member
        /// </summary>
        /// <param name="logger">NLog.Logger</param>
        /// <param name="msg">Message</param>
        /// <param name="filePath">CallerFilePath</param>
        /// <param name="memberName">CallerMemberName</param>
        /// <param name="lineNumber">CallerLineNumber</param>
        public static void FatalMember(this NLog.Logger logger, string msg,
            [CallerFilePath] string filePath = "",
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            internalLog(logger, LogLevel.Fatal, filePath, memberName, lineNumber, msg);
        }


        private static void internalLog(
            NLog.Logger logger,
            LogLevel logLevel,
            string filePath,
            string memberName,
            int lineNumber,
            string msg)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");

            if (logLevel == null)
                throw new ArgumentNullException("logLevel");

            const string format = "Member : {2} at  {1}, line {3}. {0}";
            logger.Log(logLevel, format, msg, filePath, memberName, lineNumber);
        }
    }
}