using System;
using System.Collections.Generic;
using System.Text;
using Loggers;
using Loggers.Contract;

namespace CustomeLogger
{
    public class BufferMessage : IBufferMessage
    {
        public BufferMessage(ILoggerMessage loggerMessage, string writer)
        {
            LoggerMessage = loggerMessage;
            WrittenBy = writer;
        }

        public ILoggerMessage LoggerMessage { get; }

        public string WrittenBy { get; }

        public override string ToString()
        {
            var loggerMessage = LoggerMessage.ToString().Replace("====", "").Replace(".", ";");
            return string.Format($"===={ loggerMessage }Written by: {WrittenBy}.\n====");
        }
    }
}
