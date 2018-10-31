using _Logger.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Contract
{
    /// <summary>
    /// NOT USED
    /// </summary>
    public abstract class LoggerBase : ILogger
    {

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }

        public abstract LoggerMessage GetLoggerMessage(LogLevel logLevel, string message);
        public abstract void WriteLog(LogLevel logLevel, string message);
    }
}
