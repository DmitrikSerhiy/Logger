using _Logger.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Implementation
{
    public class Logger : ILogger//LoggerBase
    {
        private IWriter _writer;
        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        public void Debug(string message)
        {
            _writer.Write(new LoggerMessage(LogLevel.Debug, message));
        }

        public void Error(string message)
        {
            _writer.Write(new LoggerMessage(LogLevel.Error, message));
        }

        public void Fatal(string message)
        {
            _writer.Write(new LoggerMessage(LogLevel.Fatal, message));
        }

        public void Info(string message)
        {
            _writer.Write(new LoggerMessage(LogLevel.Information, message));
        }

        public void Warn(string message)
        {
            _writer.Write(new LoggerMessage(LogLevel.Warning, message));
        }


        public LoggerMessage GetLoggerMessage(LogLevel logLevel, string message)
        {
            return new LoggerMessage(logLevel, message);
        }

        public void WriteLog(LogLevel logLevel, string message)
        {
            _writer.Write(new LoggerMessage(logLevel, message));
        }

        //In case BaseLogger comes back
        //public new void Debug(string message)
        //{
        //    _writer.Write(new LoggerMessage(LogLevel.Debug, message));
        //}

        //public new void Error(string message)
        //{
        //    _writer.Write(new LoggerMessage(LogLevel.Error, message));
        //}

        //public new void Fatal(string message)
        //{
        //    _writer.Write(new LoggerMessage(LogLevel.Fatal, message));
        //}

        //public new void Info(string message)
        //{
        //    throw new NotImplementedException();
        //}

        //public new void Warn(string message)
        //{
        //    _writer.Write(new LoggerMessage(LogLevel.Warning, message));
        //}
    }
}
