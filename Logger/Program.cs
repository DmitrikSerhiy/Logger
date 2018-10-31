using _Logger.Contract;
using _Logger.Implementation;
using CustomeLogger.Writter;
using Microsoft.Extensions.DependencyInjection;
using System;

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
                .AddSingleton<IWriter, ConsoleWriter>()
                .BuildServiceProvider();
            return serviceProvider;
        }

        static void Main(string[] args)
        {
            var serviceProvider = GetServiceProvider();
            var logger = serviceProvider.GetService<ILogger>();
            //var wr = new ConsoleWriter();
            //Logger myLogger = new Logger(wr);

            logger.Error("My message");
            logger.Fatal("My message");
            logger.Debug("My message");
            logger.Info("My message");
            logger.Warn("My message");
            Console.ReadKey();
        }
    }
}
