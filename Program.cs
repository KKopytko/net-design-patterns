using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Patterns.Examples;

namespace Patterns
{
    class Program
    {
        private static readonly IDictionary<int, RunnableExample> examples;

        static Program()
        {
            examples = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(eType => eType.IsClass &&
                    !eType.IsAbstract &&
                    eType.IsSubclassOf(typeof(RunnableExample)))
                .Select(e => Activator.CreateInstance(e) as RunnableExample)
                .OrderBy(e => e.GetType().Name)
                .Select((example, index) => new {index, example})
                .ToDictionary(x => x.index + 1, x => x.example);
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo choice;
            do
            {
                PresentListOfExamples();

                choice = PromptPickKey("Select example: ");
                if (ShouldBreak(choice))
                {
                    break;
                }

                if (!GetExample(choice, out var selectedExample))
                {
                    continue;
                }

                RunExample(selectedExample);

                choice = PromptPickKey("\nEnd of run. Press any key to return to menu.");
            } while (!ShouldBreak(choice));
        }

        private static void PresentListOfExamples()
        {
            Console.Clear();
            foreach(var example in examples)
            {
                Console.WriteLine($"{example.Key}) {example.Value.Name}");
            }
            Console.WriteLine("ESC) Exit");
        }

        private static ConsoleKeyInfo PromptPickKey(string title)
        {
            Console.Write($"\n{title}");

            return Console.ReadKey(true);
        }

        private static bool GetExample(ConsoleKeyInfo choice, out RunnableExample example)
        {
            var intChoice = (int)char.GetNumericValue(choice.KeyChar);
            
            return examples.TryGetValue(intChoice, out example);
        }

        private static void RunExample(RunnableExample example)
        {
            Console.Clear();
            Console.WriteLine($"=== {example.Name} ===\n");
            example.Run();
        }

        private static bool ShouldBreak(ConsoleKeyInfo choice)
        {
            return choice.Key == ConsoleKey.Escape;
        }
    }
}
