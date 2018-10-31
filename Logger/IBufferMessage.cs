using Loggers;
using Loggers.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomeLogger
{
    public interface IBufferMessage
    {
        ILoggerMessage LoggerMessage { get; }
        string WrittenBy { get; }

        string ToString();
    }
}
