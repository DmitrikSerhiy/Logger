using Loggers.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers.Implementation
{
    public class Logger : LoggerBase
    {
        private IWriter writer;
        public Logger(IWriter Writer) : base(Writer)
        {
            writer = Writer;
        }

        public override LoggerMessage GetLoggerMessage(LogLevel logLevel, string message)
        {
            return new LoggerMessage(logLevel, message);
        }

        public override void WriteLog(LogLevel logLevel, string message)
        {
            writer.Write(new LoggerMessage(logLevel, message));
        }
    }
}
