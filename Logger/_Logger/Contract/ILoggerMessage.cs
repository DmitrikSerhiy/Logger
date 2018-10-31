using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Contract
{
    public interface ILoggerMessage
    {
        LogLevel Level { get; }
        DateTime LogDateTime { get; }
        string Message { get; }

        string ToString();
    }
}
