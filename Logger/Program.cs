using Loggers.Contract;
using Loggers.Implementation;
using CustomeLogger.Writter;
using Microsoft.Extensions.DependencyInjection;
using System;
using CustomeLogger;

namespace Loggers
{
    class Program
    {
        private static ILogger logger;
        public Program(ILogger Logger)
        {
            logger = Logger;
        }

        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILogger, Logger>()
                .AddSingleton<IBatchLogger, BatchLogger>()
                .AddSingleton<IWriter, ConsoleWriter>() 
                .AddSingleton<IBatchWriter, FileLogWriter>()
                .BuildServiceProvider();
            return serviceProvider;
        }

        static void Main(string[] args)
        {
            var serviceProvider = GetServiceProvider();
            var logger = serviceProvider.GetService<ILogger>();
            var batchlogger = serviceProvider.GetService<IBatchLogger>() as BatchLogger;

            var logToBuff = logger.Error("My message");
            //logger.Fatal("My message");
            //logger.Debug("My message");
            //logger.Info("My message");
            //logger.Warn("My message");

            var logtoBuf2 = batchlogger.Error("My message in File");
            //batchlogger.Fatal("My message in File");
            //batchlogger.Debug("My message in File");
            //batchlogger.Info("My message in File");
            //batchlogger.Warn("My message in File");


            logger.BuffLog(logToBuff);
            batchlogger.BuffLog(logtoBuf2);
            Console.WriteLine(CustomeBuffer.GetBufferedMessages());

            Console.ReadKey();
        }
    }
}
