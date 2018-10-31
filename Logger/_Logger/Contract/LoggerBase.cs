using _Logger.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Contract
{
    public abstract class LoggerBase : ILogger
    {
        private IWriter writer;
        public LoggerBase(IWriter Writer)
        {
            writer = Writer;
        }

        public void Debug(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Debug, message));
        }

        public void Error(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Error, message));
        }

        public void Fatal(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Fatal, message));
        }

        public void Info(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Information, message));
        }

        public void Warn(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Warning, message));
        }

        public abstract LoggerMessage GetLoggerMessage(LogLevel logLevel, string message);
        public abstract void WriteLog(LogLevel logLevel, string message);
    }
}
