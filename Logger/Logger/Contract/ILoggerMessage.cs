using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers.Contract
{
    public interface ILoggerMessage
    {
        LogLevel Level { get; }
        DateTime LogDateTime { get; }
        string Message { get; }

        string ToString();
    }
}
