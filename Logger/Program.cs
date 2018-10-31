using _Logger.Implementation;
using CustomeLogger.Writter;
using System;

namespace _Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var wr = new ConsoleWriter();
            Logger myLogger = new Logger(wr);
            myLogger.Error("My message");
            myLogger.Fatal("My message");
            myLogger.Debug("My message");
            myLogger.Info("My message");
            myLogger.Warn("My message");
            Console.ReadKey();
        }
    }
}
