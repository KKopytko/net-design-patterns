using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Patterns.Examples;

namespace Patterns
{
    class Program
    {
        private static readonly IDictionary<int, IRunnableExample> examples;

        static Program()
        {
            examples = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(eType => eType.IsClass &&
                    !eType.IsAbstract &&
                    eType.GetInterfaces().Contains(typeof(IRunnableExample)))
                .Select(e => Activator.CreateInstance(e) as IRunnableExample)
                .Select((example, index) => new {index, example})
                .ToDictionary(x => x.index + 1, x => x.example);
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo choice;
            do
            {
                Console.Clear();
                foreach(var example in examples)
                {
                    Console.WriteLine($"{example.Key}) {example.Value.Name}");
                }

                Console.Write("\nWybierz przyklad: ");
                choice = Console.ReadKey(true);
                if (choice.Key == ConsoleKey.Escape)
                {
                    break;
                }

                var intChoice = (int)char.GetNumericValue(choice.KeyChar);
                IRunnableExample selectedExample;
                if (!examples.TryGetValue(intChoice, out selectedExample))
                {
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"=== {selectedExample.Name} ===\n");
                selectedExample.Run();

                Console.WriteLine("\n\nKoniec wykonania. Wcisnij przycisk by powrocic do Menu.");
                choice = Console.ReadKey(true);
            } while(choice.Key != ConsoleKey.Escape);
        }
    }
}
