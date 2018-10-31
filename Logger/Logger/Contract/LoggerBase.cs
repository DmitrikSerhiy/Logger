using Loggers.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers.Contract
{
    public abstract class LoggerBase : ILogger
    {
        private IWriter writer;
        private LoggerMessage loggerMessage;
        public LoggerBase(IWriter Writer)
        {
            writer = Writer;
        }

        public ILoggerMessage Debug(string message)
        {
            loggerMessage = new LoggerMessage(LogLevel.Debug, message);
            writer.Write(loggerMessage);
            return loggerMessage;
        }

        public ILoggerMessage Error(string message)
        {
            loggerMessage = new LoggerMessage(LogLevel.Error, message);
            writer.Write(loggerMessage);
            return loggerMessage;
        }

        public ILoggerMessage Fatal(string message)
        {
            loggerMessage = new LoggerMessage(LogLevel.Fatal, message);
            writer.Write(loggerMessage);
            return loggerMessage;
        }

        public ILoggerMessage Info(string message)
        {
            loggerMessage = new LoggerMessage(LogLevel.Information, message);
            writer.Write(loggerMessage);
            return loggerMessage;
        }

        public ILoggerMessage Warn(string message)
        {
            loggerMessage = new LoggerMessage(LogLevel.Warning, message);
            writer.Write(loggerMessage);
            return loggerMessage;
        }

        public abstract LoggerMessage GetLoggerMessage(LogLevel logLevel, string message);
        public abstract void WriteLog(LogLevel logLevel, string message);
    }
}
