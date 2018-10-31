using _Logger.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger
{
    public interface IWriter
    {
        void Write(LoggerMessage loggerMessage); 
    }
}
