using Loggers;
using Loggers.Contract;
using Loggers.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomeLogger.Writter
{
    public class ConsoleWriter : IWriter
    {
        public void Write(LoggerMessage loggerMessage)
        {
            Console.WriteLine("Console logger:");
            Console.Write(loggerMessage.ToString());
        }
    }
}
