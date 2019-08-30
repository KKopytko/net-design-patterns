using System;

namespace Patterns.Examples.Singleton
{
    class SingletonExample : RunnableExample
    {
        public override void Run()
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