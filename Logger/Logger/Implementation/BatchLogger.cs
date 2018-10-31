using Loggers.Contract;
using CustomeLogger.Writter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers.Implementation
{
    public class BatchLogger : Logger, IBatchLogger
    {
        private IBatchWriter writer;

        public BatchLogger(IBatchWriter Writer) : base(Writer)
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
