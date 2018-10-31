using Loggers.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers
{
    public interface IWriter
    {
        void Write(LoggerMessage loggerMessage);
    }
}
