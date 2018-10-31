using Loggers.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers.Contract
{
    public interface ILogger
    {
        ILoggerMessage Debug(string message);
        ILoggerMessage Error(string message);
        ILoggerMessage Fatal(string message);
        ILoggerMessage Info(string message);
        ILoggerMessage Warn(string message);
    }
}
