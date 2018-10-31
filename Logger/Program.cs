using _Logger.Contract;
using _Logger.Implementation;
using CustomeLogger.Writter;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace _Logger
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
            var logger = serviceProvider.GetService<ILogger>() as Logger;
            var batchlogger = serviceProvider.GetService<IBatchLogger>() as BatchLogger;


            logger.Error("My message");
            logger.Fatal("My message");
            logger.Debug("My message");
            logger.Info("My message");
            logger.Warn("My message");


            batchlogger.Error("My message in File");
            batchlogger.Fatal("My message in File");
            batchlogger.Debug("My message in File");
            batchlogger.Info("My message in File");
            batchlogger.Warn("My message in File");
            Console.ReadKey();
        }
    }
}
