using _Logger;
using _Logger.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomeLogger.Writter
{
    public interface IBatchWriter : IWriter
    {
        void Write(List<ILoggerMessage> messages);
    }
}
