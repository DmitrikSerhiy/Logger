using CustomeLogger.Writter;
using Loggers;
using Loggers.Contract;
using Loggers.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomeLogger
{
    public static class CustomeBuffer
    {
        private static ICollection<IBufferMessage> _bufferedMessages = new List<IBufferMessage>();

        public static void BuffLog(this ILogger logger, ILoggerMessage loggerMessage)
        {
            var writerType = logger is BatchLogger ? typeof(FileLogWriter) : typeof(ConsoleWriter);
            _bufferedMessages.Add(new BufferMessage(loggerMessage, writerType.Name));
        }

        public static string GetBufferedMessages()
        {
            Console.WriteLine("\nBuffer: ");
            return new StringBuilder().AppendJoin("\n", _bufferedMessages).ToString();
        }

        //public static 
        //public void AddToBuffer(ILoggerMessage loggerMessage, IWriter writer)
        //{
        //    _bufferedMessages.Add(new BufferMessage(loggerMessage, writer));
        //}
        
    }
}
