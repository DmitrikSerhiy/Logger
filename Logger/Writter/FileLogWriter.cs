using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Loggers.Contract;
using Loggers.Implementation;

namespace CustomeLogger.Writter
{
    public class FileLogWriter : IBatchWriter
    {
        private string filePath { get; } = Path.Combine(Directory.GetCurrentDirectory(), "logger.txt");
        public void Write(List<ILoggerMessage> messages)
        {
            using (var stream = new StreamWriter(filePath, File.Exists(filePath), System.Text.Encoding.Default))
            {
                foreach (var loggerMessage in messages)
                {
                    stream.WriteLine(loggerMessage.ToString());
                }
            }
        }

        public void Write(LoggerMessage loggerMessage)
        {
            File.AppendAllText(filePath, loggerMessage.ToString() + Environment.NewLine);
        }
    }
}
