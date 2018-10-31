using _Logger;
using _Logger.Contract;
using _Logger.Implementation;
using CustomeLogger.Writter;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Implementation
{
    public class BatchLogger : Logger, IBatchLogger
    {
        private IBatchWriter writer;

        public BatchLogger(IBatchWriter Writer) : base(Writer as IWriter)
        {
            writer = Writer as IBatchWriter;
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
