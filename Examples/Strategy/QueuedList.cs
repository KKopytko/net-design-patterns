using System;
using System.Collections.Generic;

namespace Patterns.Examples.Strategy
{
    class QueuedList
    {
        private readonly LinkedList<string> list = new LinkedList<string>();
        private QueueStrategy queueStrategy;

        public void SetQueueStrategy(QueueStrategy queueStrategy)
        {
            this.queueStrategy = queueStrategy;
            Console.WriteLine($"- Strategy: {queueStrategy.GetType().Name}");
        }

        public void Add(string person)
        {
            queueStrategy.Add(list, person);
            PresentList();
        }

        public void Clear()
        {
            list.Clear();
            Console.WriteLine("");
        }

        public string Pop()
        {
            var person = queueStrategy.Pop(list);
            PresentList();

            return person;
        }

        private void PresentList()
        {
            Console.WriteLine(string.Join(" / ", list));
        }
    }
}