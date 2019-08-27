using System;

namespace Patterns.Examples.AbstractFactory
{
    class SUV : Body
    {
        public override void InstallWindow(Window window)
        {
            Console.WriteLine($"{GetType().Name} has installed {window.GetType().Name}");
        }
    }
}