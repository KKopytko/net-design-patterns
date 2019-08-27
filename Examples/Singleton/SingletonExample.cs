using System;

namespace Patterns.Examples.Singleton
{
    public class SingletonExample : IRunnableExample
    {
        public string Name => "Singleton";

        public void Run()
        {
            var loggerA = MultiLogger.GetLogger();
            var loggerB = MultiLogger.GetLogger();

            if (loggerA.Equals(loggerB)) {
                Console.WriteLine("The same instances");
            }

            loggerA.WriteLine("Test A");
            loggerB.WriteLine("Test B");
        }
    }
}