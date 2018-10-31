using Loggers.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Loggers.Implementation
{
    public class LoggerMessage : ILoggerMessage
    {
        public LoggerMessage(LogLevel Level, string Message)
        {
            this.Level = Level;
            this.Message = Message; 
            LogDateTime = DateTime.Now;
        }
        public LogLevel Level { get; }

        public DateTime LogDateTime { get; }

        public string Message { get; }

        public override string ToString()
        {
            var time = LogDateTime.ToString(new CultureInfo("uk-UA")) + ", " + LogDateTime.Kind;
            return string.Format($"====\nDate: {time}; \nLogLevel: {Level.ToString()}; \nMessage: {Message}.\n====");
        }
    }
}
